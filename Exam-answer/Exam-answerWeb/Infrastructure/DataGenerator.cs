using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_answerWeb.Infrastructure.crt251;
using System.Text;
using Exam_answerWeb.Infrastructure.Questions;

namespace Exam_answerWeb.Infrastructure
{
    public class DataGenerator
    {
        public static List<ExamEntity> Initialize(ExamAnswerContext context)
        {
            List<ExamEntity> result = new List<ExamEntity>();

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
            crt251.Questions.Add(Q98.Instance);
            crt251.Questions.Add(Q99.Instance);
            crt251.Questions.Add(Q100.Instance);

            crt251.ShowUdemy = true;
                
            crt251.UdemyLinkUrl = "https://www.udemy.com/salesforce-crt-251-sales-cloud-consultant-exam-questions/?couponCode=50_OFF";
            crt251.UdemyLinkMessage = "Salesforce CRT-251: Sales Cloud Consultant - 50% OFF";
            crt251.UdemyMessage =
                "If you like what you see, please support the future development of our web site by buying this practice test at Udemy." +
                " Click this link for a 50% discount. The price is ONLY 9.99!";

            context?.Exams?.Add(crt251);

            result.Add(crt251);

            ExamEntity az100 = new ExamEntity()
            {
                Provider = "Microsoft",
                Code = "AZ-100",
                Name = "Microsoft Azure Infrastructure and Deployment",
                Questions = new List<QuestionEntity>()
            };

            az100.Questions.Add(Az100.Q1Instance);
            az100.Questions.Add(Az100.Q2Instance);
            az100.Questions.Add(Az100.Q3Instance);
            az100.Questions.Add(Az100.Q4Instance);
            az100.Questions.Add(Az100.Q5Instance);
            az100.Questions.Add(Az100.Q6Instance);
            az100.Questions.Add(Az100.Q7Instance);
            az100.Questions.Add(Az100.Q8Instance);
            az100.Questions.Add(Az100.Q9Instance);
            az100.Questions.Add(Az100.Q10Instance);
            az100.Questions.Add(Az100.Q11Instance);
            az100.Questions.Add(Az100.Q12Instance);
            az100.Questions.Add(Az100.Q13Instance);
            az100.Questions.Add(Az100.Q14Instance);
            az100.Questions.Add(Az100.Q15Instance);

            context?.Exams?.Add(az100);
            result.Add(az100);

            ExamEntity az900 = new ExamEntity()
            {
                Provider = "Microsoft",
                Code = "AZ-900",
                Name = "Microsoft Azure Fundamentals",
                Questions = new List<QuestionEntity>()
            };

            az900.Questions.Add(Az900.Q1Instance);
            az900.Questions.Add(Az900.Q2Instance);
            az900.Questions.Add(Az900.Q3Instance);
            az900.Questions.Add(Az900.Q4Instance);
            az900.Questions.Add(Az900.Q5Instance);
            az900.Questions.Add(Az900.Q6Instance);
            az900.Questions.Add(Az900.Q7Instance);
            az900.Questions.Add(Az900.Q8Instance);
            az900.Questions.Add(Az900.Q9Instance);
            az900.Questions.Add(Az900.Q10Instance);
            az900.Questions.Add(Az900.Q11Instance);
            az900.Questions.Add(Az900.Q12Instance);
            az900.Questions.Add(Az900.Q13Instance);
            az900.Questions.Add(Az900.Q14Instance);
            az900.Questions.Add(Az900.Q15Instance);
            az900.Questions.Add(Az900.Q16Instance);
            az900.Questions.Add(Az900.Q17Instance);
            az900.Questions.Add(Az900.Q18Instance);
            az900.Questions.Add(Az900.Q19Instance);

            context?.Exams?.Add(az900);
            result.Add(az900);

            context?.SaveChanges();
            return result;
            //var allquestions = crt251.Questions;

            //List<double> distances = new List<double>();

            //for (int i = 0; i < allquestions.Count; i++)
            //{
            //    for (int j = i + 1; j < allquestions.Count; j++)
            //    {
            //        QuestionEntity q1 = allquestions[i];
            //        QuestionEntity q2 = allquestions[j];


            //        StringBuilder sb1 = new StringBuilder();
            //        foreach (var content in q1.Contents)
            //        {
            //            sb1.AppendLine(content.Text);
            //        }
            //        foreach (var answer in q1.Answers)
            //        {
            //            sb1.AppendLine(answer.Text);
            //        }

            //        StringBuilder sb2 = new StringBuilder();
            //        foreach (var content in q2.Contents)
            //        {
            //            sb2.AppendLine(content.Text);
            //        }
            //        foreach (var answer in q2.Answers)
            //        {
            //            sb2.AppendLine(answer.Text);
            //        }

            //        string text1 = sb1.ToString();

            //        string text2 = sb2.ToString();

            //        var distance = LevenshteinDistance.CalculateSimilarity(text1, text2);
            //        distances.Add(distance);
            //        if (distance > 0.6)
            //        {

            //        }
            //    }
            //}
            //distances = distances.OrderByDescending(d => d).ToList();
        }
    }
}
