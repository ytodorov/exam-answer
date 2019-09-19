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
            ExamsToCheck = ExamsToCheck.Where(e => !e.Code.Equals("AZ-100", StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        [Fact]
        public void CheckForSimilarityOfQuestionsTest()
        {
            List<ExamEntity> exams = DataGenerator.Initialize(null);

            ExamEntity theExam = exams.FirstOrDefault(e => e.Code.Equals("AZ-900"));

            List<QuestionEntity> allquestions = theExam.Questions;

            List<double> distances = new List<double>();

            List<Tuple<QuestionEntity, QuestionEntity, string>> duplicatesLists =
                 new List<Tuple<QuestionEntity, QuestionEntity, string>>();

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
                }
            }
            distances = distances.OrderByDescending(d => d).ToList();
        }

        [Fact]
        public void AllQuestionsShouldHaveCorrectAnswerTest()
        {
            foreach (ExamEntity exam in ExamsToCheck)
            {
                List<int?> questionsWithoutAnswers = exam.Questions.Where(q => !q.Answers.Any(a => a.IsCorrect == true)).Select(q => q.Order).ToList();
                Assert.Empty(questionsWithoutAnswers);
            }
        }

        [Fact]
        public void AllQuestionsShouldHaveContentTest()
        {
            foreach (ExamEntity exam in ExamsToCheck)
            {
                foreach (var question in exam.Questions)
                {
                    Assert.False(string.IsNullOrWhiteSpace(question.ContentText));
                }
            }
        }

        [Fact]
        public void AllQuestionsShouldHaveExplanationsTest()
        {
            var exam = ExamsToCheck.FirstOrDefault(f => f.Code == "AZ-900");

            foreach (var question in exam.Questions)
            {
                Assert.False(string.IsNullOrWhiteSpace(question.ExplanationText));
            }
        }

        [Fact]
        public void AllQuestionsShouldHaveAnswerTextTest()
        {
            foreach (ExamEntity exam in ExamsToCheck)
            {
                foreach (var question in exam.Questions)
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
                foreach (var question in exam.Questions)
                {
                    Assert.True(question.ContentText.Length < 4000);
                    Assert.True(question.AnswerText.Length < 4000);
                    Assert.True(question.ExplanationText.Length < 4000);
                    Assert.True(question.ReferenceText.Length < 4000);
                }
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