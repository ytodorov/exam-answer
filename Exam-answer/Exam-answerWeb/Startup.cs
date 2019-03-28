using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace Exam_answerWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });

            //services.AddRouting(options =>
            //{
            //    options.LowercaseUrls = true;
            //    options.LowercaseQueryStrings = true;
            //    options.AppendTrailingSlash = false;                
            //});


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            {
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseExceptionHandler("/Home/Error");
            app.UseStatusCodePagesWithRedirects("/Home/Error2/{0}");

            app.UseHttpsRedirection();
            //app.UseStaticFiles();
            app.UseCookiePolicy();

            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/url-rewriting?view=aspnetcore-2.2
            app.UseRewriter(new RewriteOptions()
                .AddRedirect("(.*)/$", "$1", (int)HttpStatusCode.MovedPermanently) // Strip trailing slash
                .AddRedirectToWww()
                .AddRedirectToHttps()
                .Add(new RedirectLowerCaseRule())
                );

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

    public class RedirectLowerCaseRule : IRule
    {
        public int StatusCode { get; } = (int)HttpStatusCode.MovedPermanently;

        public void ApplyRule(RewriteContext context)
        {
            HttpRequest request = context.HttpContext.Request;
            PathString path = context.HttpContext.Request.Path;
            HostString host = context.HttpContext.Request.Host;

            string location = ((request.Scheme + "://" +
               host.Value + request.PathBase + request.Path).ToLower() + request.QueryString).Trim();

            if (path.HasValue && path.Value.Any(char.IsUpper) || host.HasValue && host.Value.Any(char.IsUpper))
            {
                HttpResponse response = context.HttpContext.Response;
                response.StatusCode = StatusCode;
                response.Headers[HeaderNames.Location] = (request.Scheme + "://" + host.Value + request.PathBase + request.Path).ToLower() + request.QueryString;
                context.Result = RuleResult.EndResponse;
            }
            else
            {
                context.Result = RuleResult.ContinueRules;
            }
        }
    }   
}
