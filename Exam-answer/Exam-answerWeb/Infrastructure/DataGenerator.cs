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
                    Provider = "Salesforce",
                    Code = "CRT-251",
                    Name = "Sales Cloud Consultant",
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
                crt251.Questions.Add(Q11.Instance);
                crt251.Questions.Add(Q12.Instance);
                crt251.Questions.Add(Q13.Instance);
                crt251.Questions.Add(Q14.Instance);
                crt251.Questions.Add(Q15.Instance);
                crt251.Questions.Add(Q16.Instance);
                crt251.Questions.Add(Q17.Instance);
                crt251.Questions.Add(Q18.Instance);
                crt251.Questions.Add(Q19.Instance);
                crt251.Questions.Add(Q20.Instance);
                crt251.Questions.Add(Q21.Instance);
                crt251.Questions.Add(Q22.Instance);
                crt251.Questions.Add(Q23.Instance);
                crt251.Questions.Add(Q24.Instance);
                crt251.Questions.Add(Q25.Instance);
                crt251.Questions.Add(Q26.Instance);
                crt251.Questions.Add(Q27.Instance);
                crt251.Questions.Add(Q28.Instance);
                crt251.Questions.Add(Q29.Instance);
                crt251.Questions.Add(Q30.Instance);
                crt251.Questions.Add(Q31.Instance);
                crt251.Questions.Add(Q32.Instance);
                crt251.Questions.Add(Q33.Instance);
                crt251.Questions.Add(Q34.Instance);
                crt251.Questions.Add(Q35.Instance);
                crt251.Questions.Add(Q36.Instance);
                crt251.Questions.Add(Q37.Instance);
                crt251.Questions.Add(Q38.Instance);
                crt251.Questions.Add(Q39.Instance);
                crt251.Questions.Add(Q40.Instance);
                crt251.Questions.Add(Q41.Instance);
                crt251.Questions.Add(Q42.Instance);
                crt251.Questions.Add(Q43.Instance);
                crt251.Questions.Add(Q44.Instance);
                crt251.Questions.Add(Q45.Instance);
                crt251.Questions.Add(Q46.Instance);
                crt251.Questions.Add(Q47.Instance);




                context.Exams.Add(crt251);
                context.SaveChanges();
            }
        }
    }
}
