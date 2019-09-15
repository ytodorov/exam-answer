using DAL.Entities;
using Exam_answerWeb.Infrastructure;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Exam_answerWeb
{
    public class Program
    {
        public static void Main(string[] args)
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

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}