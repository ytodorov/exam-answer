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

    public class ParseQuestions
    {
        [Fact]
        public void ParseAz900()
        {

            List<QuestionEntity> questions = new List<QuestionEntity>();

            List<string> paths = new List<string>()
            {
                "Az900RawQuestions19.txt",
                "Az900RawQuestions40.txt",
                "Az900RawQuestions48.txt",
                "Az900RawQuestions60.txt"
            };

            foreach (var path in paths)
            {
                var lines = File.ReadAllLines(path).ToList();
                var allText = File.ReadAllText(path);

                var linesStartingWithQuestion = lines.Where(l => l.StartsWith("QUESTION "));
                List<int> indexes = new List<int>();

                foreach (var line in linesStartingWithQuestion)
                {
                    var index = lines.IndexOf(line);
                    indexes.Add(index);
                }
                indexes.Add(lines.Count);


                for (int i = 0; i < indexes.Count - 1; i++)
                {
                    var currentIndex = indexes[i];
                    var nextIndex = indexes[i + 1];
                    var questionLines = lines.Skip(currentIndex).Take(nextIndex - currentIndex).ToList();

                    var answer1 = questionLines.FirstOrDefault(f => f.Trim().StartsWith("A."));

                    var indexOfFirstAnswer = questionLines.IndexOf(answer1);

                    var linesWithContent = questionLines.Skip(1).Take(indexOfFirstAnswer - 1).ToList();

                    QuestionEntity questionEntity = new QuestionEntity();

                    questionEntity.Contents = new List<ContentEntity>();
                    questionEntity.Answers = new List<AnswerEntity>();

                    foreach (var lineWithContent in linesWithContent)
                    {
                        questionEntity.Contents.Add(new ContentEntity()
                        {
                            Text = lineWithContent
                        });
                    }

                    string lineWithCorrectAnswer = questionLines.FirstOrDefault(f => f.StartsWith("Correct Answer: "));

                    if (string.IsNullOrEmpty(lineWithCorrectAnswer))
                    {
                        continue;
                    }

                    List<char> correctAnswers = lineWithCorrectAnswer.Replace("Correct Answer: ", string.Empty).Trim().ToCharArray().ToList();

                    if (!string.IsNullOrEmpty(answer1))
                    {
                        var answerText1 = answer1.Replace("A. ", string.Empty).Trim();
                        bool isCorrect1 = correctAnswers.Any(c => c.ToString() == "A");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText1, IsCorrect = isCorrect1 });
                    }

                    string answer2 = questionLines.FirstOrDefault(f => f.StartsWith("B."));
                    if (!string.IsNullOrEmpty(answer2))
                    {
                        var answerText2 = answer2.Replace("B. ", string.Empty).Trim();
                        bool isCorrect2 = correctAnswers.Any(c => c.ToString() == "B");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText2, IsCorrect = isCorrect2 });
                    }

                    string answer3 = questionLines.FirstOrDefault(f => f.StartsWith("C."));
                    if (!string.IsNullOrEmpty(answer3))
                    {
                        var answerText3 = answer3.Replace("C. ", string.Empty).Trim();
                        bool isCorrect3 = correctAnswers.Any(c => c.ToString() == "C");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText3, IsCorrect = isCorrect3 });
                    }

                    string answer4 = questionLines.FirstOrDefault(f => f.StartsWith("D."));
                    if (!string.IsNullOrEmpty(answer4))
                    {
                        var answerText4 = answer4.Replace("D. ", string.Empty).Trim();
                        bool isCorrect4 = correctAnswers.Any(c => c.ToString() == "D");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText4, IsCorrect = isCorrect4 });
                    }

                    string answer5 = questionLines.FirstOrDefault(f => f.StartsWith("E."));
                    if (!string.IsNullOrEmpty(answer5))
                    {
                        var answerText5 = answer5.Replace("E. ", string.Empty).Trim();
                        bool isCorrect5 = correctAnswers.Any(c => c.ToString() == "E");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText5, IsCorrect = isCorrect5 });
                    }

                    string answer6 = questionLines.FirstOrDefault(f => f.StartsWith("F."));
                    if (!string.IsNullOrEmpty(answer6))
                    {
                        var answerText6 = answer6.Replace("F. ", string.Empty).Trim();
                        bool isCorrect6 = correctAnswers.Any(c => c.ToString() == "F");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText6, IsCorrect = isCorrect6 });
                    }
                    questionEntity.Order = questions.Count + 1;
                    questions.Add(questionEntity);
                }
            }

            List<double> distances = new List<double>();

            List<QuestionEntity> duplicateQuestions = new List<QuestionEntity>();

            for (int i = 0; i < questions.Count; i++)
            {
                for (int j = i + 1; j < questions.Count; j++)
                {
                    QuestionEntity q1 = questions[i];
                    QuestionEntity q2 = questions[j];


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
                    if (distance > 0.9)
                    {
                        if (!duplicateQuestions.Any(q => q.Order == q1.Order))
                        {
                            duplicateQuestions.Add(q1);
                        }
                    }
                }
            }
            distances = distances.OrderByDescending(d => d).ToList();
        }
    }
}
