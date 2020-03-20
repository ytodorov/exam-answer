using DAL.Entities;
using Exam_answerWeb.Infrastructure;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Exam_answerWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //1. Get the IWebHost which will host this application.
                IWebHost host = CreateWebHostBuilder(args).Build();

                //2. Find the service layer within our scope.
                using (IServiceScope scope = host.Services.CreateScope())
                {
                    //3. Get the instance of BoardGamesDBContext in our services layer
                    IServiceProvider services = scope.ServiceProvider;
                    ExamAnswerContext context = services.GetRequiredService<ExamAnswerContext>();

                    //4. Call the DataGenerator to create sample data
                    DataGenerator.Initialize(context);
                }

                //Continue to run the application
                host.Run();
            }
            catch (Exception ex)
            {
                //File.WriteAllText(@"C:\inetpub\wwwroot\yordanError.txt", ex.Message + ex.StackTrace);
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                  .CaptureStartupErrors(true)
                .UseSetting("detailedErrors", "true")
                .UseStartup<Startup>();
    }
}