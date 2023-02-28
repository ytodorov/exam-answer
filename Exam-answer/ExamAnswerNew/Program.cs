using Microsoft.AspNetCore.Rewrite;
using Microsoft.Net.Http.Headers;

namespace ExamAnswerNew
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddResponseCompression(c => c.EnableForHttps = true);
            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            var options = new RewriteOptions()
                .AddRewrite(@"^([^.]+)/?$", "$1.html", skipRemainingRules: true);
            app.UseRewriter(options);

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseResponseCompression();

            //app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = ctx =>
                {
                    ctx.Context.Response.Headers[HeaderNames.Vary] = new[] { "Accept-Encoding" };
                }
            });


            app.MapGet("/", async (HttpContext context) =>
            {
                var html = File.ReadAllText(Path.Combine(app.Environment.WebRootPath, "index.html"));
                await context.Response.WriteAsync(html);
            });

            app.Run();
        }
    }
}