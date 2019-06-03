using DAL.Entities;
using Exam_answerWeb.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;


namespace UnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void CheckForSimilarityCrt251Test()
        {

            var exams = DataGenerator.Initialize(null);

            var crt251 = exams.FirstOrDefault();

            var allquestions = crt251.Questions;

            List<double> distances = new List<double>();

            for (int i = 0; i < allquestions.Count; i++)
            {
                for (int j = i + 1; j < allquestions.Count; j++)
                {
                    QuestionEntity q1 = allquestions[i];
                    QuestionEntity q2 = allquestions[j];


                    StringBuilder sb1 = new StringBuilder();
                    foreach (var content in q1.Contents)
                    {
                        sb1.AppendLine(content.Text);
                    }
                    foreach (var answer in q1.Answers)
                    {
                        sb1.AppendLine(answer.Text);
                    }

                    StringBuilder sb2 = new StringBuilder();
                    foreach (var content in q2.Contents)
                    {
                        sb2.AppendLine(content.Text);
                    }
                    foreach (var answer in q2.Answers)
                    {
                        sb2.AppendLine(answer.Text);
                    }

                    string text1 = sb1.ToString();

                    string text2 = sb2.ToString();

                    var distance = LevenshteinDistance.CalculateSimilarity(text1, text2);
                    distances.Add(Math.Round(distance, 2));
                    if (distance > 0.51)
                    {

                    }
                }
            }
            distances = distances.OrderByDescending(d => d).ToList();


        }

        [Fact]
        public void CheckWithoutAnswersCrt251Test()
        {

            var exams = DataGenerator.Initialize(null);

            var crt251 = exams.FirstOrDefault();

            var allquestions = crt251.Questions.Where(q => !q.Answers.Any(a => a.IsCorrect == true)).Select(q => q.Order).ToList();
        }

        [Fact]
        public void CreateExportTest()
        {
            var exams = DataGenerator.Initialize(null);

            var crt251 = exams.FirstOrDefault();

            StringBuilder stringBuilder = new StringBuilder();

            var result = stringBuilder.ToString();

            File.WriteAllText("exportCrt-251.csv", result);
                
        }

        [Fact]
        public void Test1()
        {
            //DbContextOptions<ExamAnswerContext> options = new DbContextOptions<ExamAnswerContext>();

            //using (ExamAnswerContext context = new ExamAnswerContext(options))
            //{

            //}
            //ExamEntity examEntity = examAnswerContext.Exams
            //   .Where(e => e.Provider.Equals(provider, StringComparison.InvariantCultureIgnoreCase) &&
            //       e.Code.Equals(examCode, StringComparison.InvariantCultureIgnoreCase))

            //   .Include(e => e.Questions)
            //   .ThenInclude(q => q.Contents)

            //   .Include(e => e.Questions)
            //   .ThenInclude(q => q.Answers)

            //   .Include(e => e.Questions)
            //   .ThenInclude(q => q.Explanations)

            //   .Include(e => e.Questions)
            //   .ThenInclude(q => q.References)

            //   .AsNoTracking()

            //   .FirstOrDefault();

            //var examViewModel = mapper.Map<ExamViewModel>(examEntity);

            var res = LevenshteinDistance.CalculateSimilarity(@"
 Universal Containers’ current solution for managing its forecasts is cumbersome.

The sales managers do NOT have visibility into their teams’ forecasts and are NOT able to update the forecasts. ",


@" As a result, the managers are continually asking their sales representatives to provide updated forecast data via email or phone.

Which two solutions should a consultant recommend to help Universal Containers improve the management of their forecasts? (Choose two.) ");
        }
    }
}
