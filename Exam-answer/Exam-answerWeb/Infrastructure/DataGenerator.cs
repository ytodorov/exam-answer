using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_answerWeb.Infrastructure.crt251;

namespace Exam_answerWeb.Infrastructure
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExamAnswerContext(
                serviceProvider.GetRequiredService<DbContextOptions<ExamAnswerContext>>()))
            {
                ExamEntity crt251 = new ExamEntity()
                {
                    Questions = new List<QuestionEntity>()
                };

                crt251.Questions.Add(Q1.Instance);
                crt251.Questions.Add(Q2.Instance);
                crt251.Questions.Add(Q3.Instance);
                crt251.Questions.Add(Q4.Instance);
                crt251.Questions.Add(Q5.Instance);
                crt251.Questions.Add(Q6.Instance);
                crt251.Questions.Add(Q7.Instance);
                crt251.Questions.Add(Q8.Instance);
                crt251.Questions.Add(Q9.Instance);
                crt251.Questions.Add(Q10.Instance);

                context.Exams.Add(crt251);
                context.SaveChanges();
            }
        }
    }
}
