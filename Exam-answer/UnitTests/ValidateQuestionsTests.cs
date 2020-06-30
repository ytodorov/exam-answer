using AngleSharp.Common;
using AutoMapper.Configuration.Annotations;
using DAL.Entities;
using Exam_answerWeb.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace UnitTests
{
    public class ValidateQuestionsTests
    {
        public List<ExamEntity> ExamsToCheck { get; set; }

        public ValidateQuestionsTests()
        {
            ExamsToCheck = DataGenerator.Initialize(null);
            //ExamsToCheck = ExamsToCheck.Where(e => !e.Code.Equals("AZ-100", StringComparison.CurrentCultureIgnoreCase)).ToList();
        }


        [Fact(Skip = "temp - very slow")]
        public void CheckForSimilarityOfCustomTextTest()
        {
            List<ExamEntity> exams = DataGenerator.Initialize(null);

            ExamEntity theExam = exams.FirstOrDefault(e => e.Code.Equals("AZ-900"));

            List<QuestionEntity> allquestions = theExam.Questions;

            List<double> distances = new List<double>();

            List<Tuple<QuestionEntity, QuestionEntity, string>> duplicatesLists =
                 new List<Tuple<QuestionEntity, QuestionEntity, string>>();

            for (int i = 0; i < allquestions.Count; i++)
            {

                QuestionEntity q1 = allquestions[i];

                string text1 = q1.ContentText.Replace(" ", string.Empty) + q1.AnswerText.Replace(" ", string.Empty);

                string questionText = @"This question requires that you evaluate the underlined text to determine if it is correct.
When you are implementing a software as a service (SaaS) solution, you are responsible for configuring high availability.
Instructions: Review the underlined text. If it makes the statement correct, select If the statement is incorrect, select the answer choice that makes the statement correct.
A.No change is needed.
B.defining scalability rules
C.installing the SaaS solution
D.configuring the SaaS solution


";
                string answerText = string.Empty;

                string text2 = questionText.Replace(" ", string.Empty); // + answerText.Replace(" ", string.Empty);

                string helperTextForDebug = $"{q1.Id + 1}{text1}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}{q1.Id + 1}{text2}";

                double distance = LevenshteinDistance.CalculateSimilarity(text1, text2);
                distances.Add(Math.Round(distance, 2));
                if (distance > 0.81)
                {
                    duplicatesLists.Add(new Tuple<QuestionEntity, QuestionEntity, string>(
                        q1, q1, distance.ToString()));

                    string textToSee = $"{text1} {Environment.NewLine}{Environment.NewLine} {text2}";
                }

            }
            distances = distances.OrderByDescending(d => d).ToList();
        }


        [Fact()]
        public void CheckForSimilarityOfQuestionsTest()
        {
            List<ExamEntity> exams = DataGenerator.Initialize(null);

            ExamEntity theExam = exams.FirstOrDefault(e => e.Code.Equals("az-900", StringComparison.CurrentCultureIgnoreCase));

            List<QuestionEntity> allquestions = theExam.Questions;

            List<double> distances = new List<double>();

            List<Tuple<QuestionEntity, QuestionEntity, string>> duplicatesLists =
                 new List<Tuple<QuestionEntity, QuestionEntity, string>>();

            List<Tuple<QuestionEntity, QuestionEntity, double>> distanceListAllQuestions =
                 new List<Tuple<QuestionEntity, QuestionEntity, double>>();

            for (int i = 0; i < allquestions.Count; i++)
            {
                for (int j = i + 1; j < allquestions.Count; j++)
                {
                    QuestionEntity q1 = allquestions[i];
                    QuestionEntity q2 = allquestions[j];

                    string text1 = q1.ContentText.Replace(" ", string.Empty) + q1.AnswerText.Replace(" ", string.Empty);

                    string text2 = q2.ContentText.Replace(" ", string.Empty) + q2.AnswerText.Replace(" ", string.Empty);

                    string helperTextForDebug = $"{q1.Id + 1}{text1}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}{q2.Id + 1}{text2}";

                    double distance = LevenshteinDistance.CalculateSimilarity(text1, text2);
                    distances.Add(Math.Round(distance, 2));
                    if (distance > 0.81)
                    {
                        duplicatesLists.Add(new Tuple<QuestionEntity, QuestionEntity, string>(
                            q1, q2, distance.ToString()));

                        string textToSee = $"{text1} {Environment.NewLine}{Environment.NewLine} {text2}";
                    }

                    distanceListAllQuestions.Add(new Tuple<QuestionEntity, QuestionEntity, double>(
                            q1, q2, distance));
                }
            }
            string duplicateResultHelper = string.Join("\r\n\r\n\r\n", duplicatesLists.Select(s => s.Item1.ContentText + " ----- " + s.Item2.ContentText).ToList());

            distances = distances.OrderByDescending(d => d).ToList();

            distanceListAllQuestions = distanceListAllQuestions.OrderByDescending(d => d.Item3).ToList();
        }

        [Fact]
        public void AllQuestionsShouldHaveCorrectAnswerTest()
        {
            foreach (ExamEntity exam in ExamsToCheck)
            {
                List<int?> questionsWithoutAnswers = exam.Questions.Where(q => q.QuestionType != QuestionType.DropDown && !q.Answers.Any(a => a.IsCorrect == true)).Select(q => q.Order).ToList();
                Assert.Empty(questionsWithoutAnswers);
            }
        }

        [Fact]
        public void AllQuestionsShouldHaveContentTest()
        {
            foreach (ExamEntity exam in ExamsToCheck)
            {
                foreach (QuestionEntity question in exam.Questions)
                {
                    Assert.False(string.IsNullOrWhiteSpace(question.ContentText));
                }
            }
        }

        [Fact(Skip = "only for test")]
        public void AllQuestionsShouldHaveExplanationsTest()
        {
            ExamEntity exam = ExamsToCheck.FirstOrDefault(f => f.Code == "AZ-900");

            foreach (QuestionEntity question in exam.Questions)
            {
                Assert.False(string.IsNullOrWhiteSpace(question.ExplanationText));
            }
        }

        [Fact]
        public void AllQuestionsShouldHaveAnswerTextTest()
        {
            foreach (ExamEntity exam in ExamsToCheck)
            {
                foreach (QuestionEntity question in exam.Questions)
                {
                    Assert.False(string.IsNullOrWhiteSpace(question.AnswerText));
                }
            }
        }

        [Fact]
        public void AllQuestionsShouldNotVeryLongTextTest()
        {
            foreach (ExamEntity exam in ExamsToCheck)
            {
                foreach (QuestionEntity question in exam.Questions)
                {
                    Assert.True(question.ContentText.Length < 6000); // testlets are very long
                    Assert.True(question.AnswerText.Length < 4000);
                    Assert.True(question.ExplanationText.Length < 4000);
                    Assert.True(question.ReferenceText.Length < 4000);
                }
            }
        }

        [Fact]
        public void AllQuestionsAnsewerAndTypeShouldMatchTest()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ExamEntity exam in ExamsToCheck)
            {
                foreach (QuestionEntity question in exam.Questions)
                {
                    List<AnswerEntity> correctQuestionCount = question.Answers.Where(a => a.IsCorrect.GetValueOrDefault()).ToList();

                    if (question.QuestionType == QuestionType.CheckBox)
                    {
                        //Assert.True(correctQuestionCount.Count > 0);
                        if (!(correctQuestionCount.Count > 0))
                        {
                            sb.AppendLine(question.ContentText);
                            sb.AppendLine("--------------------------------------------------------");
                            sb.AppendLine("--------------------------------------------------------");
                        }
                    }
                    else if (question.QuestionType == QuestionType.RadioButon)
                    {
                        //Assert.True(correctQuestionCount.Count == 1);
                        if (!(correctQuestionCount.Count == 1))
                        {
                            sb.AppendLine(question.ContentText);
                            sb.AppendLine("--------------------------------------------------------");
                            sb.AppendLine("--------------------------------------------------------");
                        }
                    }
                    else if (question.QuestionType == QuestionType.DropDown)
                    {
                        //Assert.True(question.Answers.All(a => a.Text.Contains(" *")));
                        if (!(question.Answers.All(a => a.Text.Contains(" *"))))
                        {
                            sb.AppendLine(question.ContentText);
                            sb.AppendLine("--------------------------------------------------------");
                            sb.AppendLine("--------------------------------------------------------");
                        }
                    }
                }
            }

            var errors = sb.ToString();
            Assert.True(string.IsNullOrEmpty(errors));
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