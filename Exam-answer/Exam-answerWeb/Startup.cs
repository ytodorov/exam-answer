using Exam_answerWeb.Infrastructure;
using Exam_answerWeb.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;

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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });

            services.Configure<GzipCompressionProviderOptions>(options =>
                options.Level = CompressionLevel.Optimal);

            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
            });

            // Add MVC services to the services container.
            services
                .AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            services
                .AddDistributedMemoryCache()
                .AddSession();

            // Add Kendo UI services to the services container
            services.AddKendo();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            string path = Path.Combine(env.WebRootPath); //"bin", version, @"netcoreapp2.2\Views\microsoft\az-100");
            List<string> files = Directory.GetFiles(path, "*question*.cshtml", SearchOption.AllDirectories).ToList();
            foreach (var filePath in files)
            {
                //string theFile = files.FirstOrDefault(f => f.EndsWith($"{filePath}.cshtml".Replace("/", "\\")));
                if (!string.IsNullOrEmpty(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);

                    string[] lines = File.ReadAllLines(filePath);
                    lines = lines.Where(l => !l.Trim().StartsWith("@") && !l.Trim().StartsWith("&") && !l.Trim().StartsWith("<")).ToArray();

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < lines.Length; i++)
                    {
                        sb.Append(lines[i]);
                    }

                    fileContent = sb.ToString().Trim();

                    FileInfo fi = new FileInfo(filePath);

                    SearchQuestionViewModel searchQuestionViewModel = new SearchQuestionViewModel()
                    {
                        FilePath = filePath,
                        Content = fileContent,
                        Title = fileContent.Substring(0, 50),
                        ExamName = fi.Directory.Name,
                        ExamProvider = fi.Directory.Parent.Name
                    };

                    StaticContent.AllQuestions.Add(searchQuestionViewModel);


                }
            }


            HostingEnvironment = env;
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseExceptionHandler("/home/exception");
            //app.UseStatusCodePagesWithRedirects("/home/error/{0}");

            app.UseHttpsRedirection();
            //app.UseStaticFiles();
            app.UseCookiePolicy();

            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/url-rewriting?view=aspnetcore-2.2
            //app.UseRewriter(new RewriteOptions()
            //    .AddRedirect("(.*)/$", "$1", (int)HttpStatusCode.MovedPermanently) // Strip trailing slash
            //    .AddRedirectToWww()
            //    .AddRedirectToHttps()
            //    .Add(new RedirectLowerCaseRule())
            //    );

            app.UseResponseCompression();

            FileExtensionContentTypeProvider provider = new FileExtensionContentTypeProvider();
            provider.Mappings[".webmanifest"] = "application/manifest+json";

            app.UseStaticFiles(new StaticFileOptions()
            {
                ContentTypeProvider = provider
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }


}
