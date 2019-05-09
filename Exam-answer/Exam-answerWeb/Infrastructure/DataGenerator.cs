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
                crt251.Questions.Add(Q48.Instance);
                crt251.Questions.Add(Q49.Instance);
                crt251.Questions.Add(Q50.Instance);
                crt251.Questions.Add(Q51.Instance);
                crt251.Questions.Add(Q52.Instance);
                crt251.Questions.Add(Q53.Instance);
                crt251.Questions.Add(Q54.Instance);
                crt251.Questions.Add(Q55.Instance);
                crt251.Questions.Add(Q56.Instance);
                crt251.Questions.Add(Q57.Instance);
                crt251.Questions.Add(Q58.Instance);
                crt251.Questions.Add(Q59.Instance);
                crt251.Questions.Add(Q60.Instance);
                crt251.Questions.Add(Q61.Instance);
                crt251.Questions.Add(Q62.Instance);
                crt251.Questions.Add(Q63.Instance);
                crt251.Questions.Add(Q64.Instance);
                crt251.Questions.Add(Q65.Instance);
                crt251.Questions.Add(Q66.Instance);
                crt251.Questions.Add(Q67.Instance);
                crt251.Questions.Add(Q68.Instance);
                crt251.Questions.Add(Q69.Instance);
                crt251.Questions.Add(Q70.Instance);
                crt251.Questions.Add(Q71.Instance);
                crt251.Questions.Add(Q72.Instance);
                crt251.Questions.Add(Q73.Instance);
                crt251.Questions.Add(Q74.Instance);
                crt251.Questions.Add(Q75.Instance);
                crt251.Questions.Add(Q76.Instance);
                crt251.Questions.Add(Q77.Instance);
                crt251.Questions.Add(Q78.Instance);
                crt251.Questions.Add(Q79.Instance);
                crt251.Questions.Add(Q80.Instance);
                crt251.Questions.Add(Q81.Instance);
                crt251.Questions.Add(Q82.Instance);
                crt251.Questions.Add(Q83.Instance);
                crt251.Questions.Add(Q84.Instance);
                crt251.Questions.Add(Q85.Instance);
                crt251.Questions.Add(Q86.Instance);
                crt251.Questions.Add(Q87.Instance);
                crt251.Questions.Add(Q88.Instance);
                crt251.Questions.Add(Q89.Instance);
                crt251.Questions.Add(Q90.Instance);
                crt251.Questions.Add(Q91.Instance);
                crt251.Questions.Add(Q92.Instance);
                crt251.Questions.Add(Q93.Instance);
                crt251.Questions.Add(Q94.Instance);
                crt251.Questions.Add(Q95.Instance);
                crt251.Questions.Add(Q96.Instance);
                crt251.Questions.Add(Q97.Instance);


                context.Exams.Add(crt251);
                context.SaveChanges();
            }
        }
    }
}
