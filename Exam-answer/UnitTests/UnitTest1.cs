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

        // [Fact]
        public void CreateExportForUdemyTest()
        {
            var exams = DataGenerator.Initialize(null);

            var crt251 = exams.FirstOrDefault();

            StringBuilder sb = new StringBuilder();



            foreach (var question in crt251.Questions)
            {
                if (!question.Answers.Any(a => a.IsCorrect == true))
                {
                    continue;
                }

                sb.Append(question.QuestionText.Replace("\"", "\"\"").Replace(",", ""));
                sb.Append(",");

                if (question.QuestionType == QuestionType.RadioButon)
                {
                    sb.Append("multiple-choice");
                    sb.Append(",");
                }
                else if (question.QuestionType == QuestionType.CheckBox)
                {
                    sb.Append("multi-select");
                    sb.Append(",");
                }

                for (int i = 0; i < 6; i++)
                {
                    if (i < question.Answers?.Count)
                    {
                        var answer = question.Answers[i];
                        sb.Append(answer.Text.Replace("\"", "\"\"").Replace(",", ""));
                        sb.Append(",");
                    }
                    else
                    {
                        //sb.Append(string.Empty);
                        sb.Append(",");
                    }
                }
                if (question.QuestionType == QuestionType.CheckBox)
                {
                    sb.Append("\"");
                }
                for (int i = 0; i < 6; i++)
                {

                    if (i < question.Answers?.Count)
                    {
                        var answer = question.Answers[i];

                        if (answer.IsCorrect == true)
                        {
                            var indexToInsert = question.Answers.IndexOf(answer) + 1;
                            sb.Append(indexToInsert);
                            if (question.QuestionType == QuestionType.CheckBox)
                            {
                                    sb.Append(",");
                            }
                        }
                    }

                }

                sb = new StringBuilder(sb.ToString().Trim(','));

                if (question.QuestionType == QuestionType.CheckBox)
                {
                    sb.Append("\"");
                }
                sb.Append(",");
                if (!string.IsNullOrEmpty(question.ExplanationText))
                {
                    sb.Append($"\"{question.ExplanationText.Replace("\"", "\"\"").Replace(",", "")}\"");
                }

                sb.Append(",");

                //string knowledgeArea = string.Empty;

                //sb.Append(knowledgeArea);

                sb.Append(Environment.NewLine);

            }

            var result = sb.ToString();

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
 Universal Containers' current solution for managing its forecasts is cumbersome.

The sales managers do NOT have visibility into their teams' forecasts and are NOT able to update the forecasts. ",


@" As a result, the managers are continually asking their sales representatives to provide updated forecast data via email or phone.

Which two solutions should a consultant recommend to help Universal Containers improve the management of their forecasts? (Choose two.) ");
        }
    }
}
