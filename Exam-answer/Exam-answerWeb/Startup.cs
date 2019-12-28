using AutoMapper;
using DAL.Entities;
using Exam_answerWeb.Extensions;
using Exam_answerWeb.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;

namespace Exam_answerWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public IHostingEnvironment HostingEnvironment { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();

            services.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });

            services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });

            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
                options.Providers.Clear();
                options.Providers.Add<BrotliCompressionProvider>();
                options.Providers.Add<GzipCompressionProvider>();
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddOutputCaching();

            // Add MVC services to the services container.
            services
                .AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            services.AddDbContext<ExamAnswerContext>(options => options.UseInMemoryDatabase(databaseName: "ExamAnswerContext"));

            //services
            //    .AddDistributedMemoryCache()
            //    .AddSession();

            // Add Kendo UI services to the services container
            services.AddKendo();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            HostingEnvironment = env;
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePagesWithRedirects("/home/error/{0}");

            app.UseHttpsRedirection();

            app.UseCookiePolicy();

            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/url-rewriting?view=aspnetcore-2.2
            app.UseRewriter(new RewriteOptions()
                .AddRedirect("(.*)/$", "$1", (int)HttpStatusCode.MovedPermanently) // Strip trailing slash
                .AddRedirectToWww()
                .AddRedirectToHttps()
                .Add(new RedirectLowerCaseRule())
                );

            app.UseResponseCompression();

            FileExtensionContentTypeProvider provider = new FileExtensionContentTypeProvider();
            provider.Mappings[".webmanifest"] = "application/manifest+json";

            app.UseStaticFiles(new StaticFileOptions()
            {
                ContentTypeProvider = provider
            });

            app.Use(
                       next =>
                       {
                           return async context =>
                           {
                               Stopwatch stopWatch = new Stopwatch();
                               stopWatch.Start();
                               context.Response.OnStarting(
                                   () =>
                                   {
                                       stopWatch.Stop();
                                       context.Response.Headers.Add("X-ResponseTime-Ms", stopWatch.ElapsedMilliseconds.ToString());

                                       // these cannot  be removed because they are not yet added here.
                                       context.Response.Headers.Remove("x-powered-by");
                                       context.Response.Headers.Remove("server");

                                       return Task.CompletedTask;
                                   });

                               await next(context);
                           };
                       });

            app.Use(
                       next =>
                       {
                           return async context =>
                           {
                               var cache = context.RequestServices.GetRequiredService<IMemoryCache>();
                               bool isMobile = context.IsMobileBrowser();
                               var cachedHtml = cache.Get<string>(context.Request.Path.ToString() + "_IsMobile_" + isMobile.ToString());
                               if (!string.IsNullOrEmpty(cachedHtml))
                               {
                                   await context.Response.WriteAsync(cachedHtml);
                               }
                               else
                               {
                                   await next(context);
                               }
                           };
                       });

            app.UseOutputCaching();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}