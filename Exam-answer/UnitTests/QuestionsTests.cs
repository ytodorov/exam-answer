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
    public class QuestionsTests
    {
        public List<ExamEntity> ExamsToCheck { get; set; }

        public QuestionsTests()
        {
            ExamsToCheck = DataGenerator.Initialize(null);
            ExamsToCheck = ExamsToCheck.Where(e => !e.Code.Equals("AZ-100", StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        [Fact]
        public void CheckForSimilarityOfQuestionsTest()
        {

            List<ExamEntity> exams = DataGenerator.Initialize(null);

            ExamEntity theExam = exams.FirstOrDefault(e => e.Code.Equals("AZ-900"));

            List<QuestionEntity> allquestions = theExam.Questions;

            List<double> distances = new List<double>();

            for (int i = 0; i < allquestions.Count; i++)
            {
                for (int j = i + 1; j < allquestions.Count; j++)
                {
                    QuestionEntity q1 = allquestions[i];
                    QuestionEntity q2 = allquestions[j];


                    StringBuilder sb1 = new StringBuilder();
                    foreach (ContentEntity content in q1.Contents)
                    {
                        sb1.AppendLine(content.Text);
                    }
                    foreach (AnswerEntity answer in q1.Answers)
                    {
                        sb1.AppendLine(answer.Text);
                    }

                    StringBuilder sb2 = new StringBuilder();
                    foreach (ContentEntity content in q2.Contents)
                    {
                        sb2.AppendLine(content.Text);
                    }
                    foreach (AnswerEntity answer in q2.Answers)
                    {
                        sb2.AppendLine(answer.Text);
                    }

                    string text1 = sb1.ToString();

                    string text2 = sb2.ToString();

                    double distance = LevenshteinDistance.CalculateSimilarity(text1, text2);
                    distances.Add(Math.Round(distance, 2));
                    if (distance > 0.999)
                    {

                    }
                }
            }
            distances = distances.OrderByDescending(d => d).ToList();


        }

        [Fact]
        public void AllQuestionsShouldHaveAnswerTest()
        {
            foreach (ExamEntity exam in ExamsToCheck)
            {
                List<int?> questionsWithoutAnswers = exam.Questions.Where(q => !q.Answers.Any(a => a.IsCorrect == true)).Select(q => q.Order).ToList();
                Assert.Empty(questionsWithoutAnswers);
            }
        }

        [Fact]
        public void AllQuestionsAnsewerAndTypeShouldMatchTest()
        {
            foreach (ExamEntity exam in ExamsToCheck)
            {
                foreach (var question in exam.Questions)
                {
                    var correctQuestionCount = question.Answers.Where(a => a.IsCorrect.GetValueOrDefault()).ToList();

                    if (question.QuestionType == QuestionType.CheckBox)
                    {
                        Assert.True(correctQuestionCount.Count > 1);
                    }
                    else if (question.QuestionType == QuestionType.RadioButon)
                    {
                        Assert.True(correctQuestionCount.Count == 1);
                    }
                }
            }
        }

        // [Fact]
        public void CreateExportForUdemyTest()
        {
            List<ExamEntity> exams = DataGenerator.Initialize(null);

            ExamEntity crt251 = exams.FirstOrDefault();

            StringBuilder sb = new StringBuilder();



            foreach (QuestionEntity question in crt251.Questions)
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
                        AnswerEntity answer = question.Answers[i];
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
                        AnswerEntity answer = question.Answers[i];

                        if (answer.IsCorrect == true)
                        {
                            int indexToInsert = question.Answers.IndexOf(answer) + 1;
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

            string result = sb.ToString();

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

            double res = LevenshteinDistance.CalculateSimilarity(@"
 Universal Containers' current solution for managing its forecasts is cumbersome.

The sales managers do NOT have visibility into their teams' forecasts and are NOT able to update the forecasts. ",


@" As a result, the managers are continually asking their sales representatives to provide updated forecast data via email or phone.

Which two solutions should a consultant recommend to help Universal Containers improve the management of their forecasts? (Choose two.) ");
        }
    }
}
