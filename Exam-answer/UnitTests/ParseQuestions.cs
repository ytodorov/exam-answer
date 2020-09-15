using DAL.Entities;
using Exam_answerWeb.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace UnitTests
{
    public class ParseQuestions
    {
        public List<ExamEntity> ExamsToCheck { get; set; }

        public ParseQuestions()
        {
            ExamsToCheck = DataGenerator.Initialize(null);
            //ExamsToCheck = ExamsToCheck.Where(e => !e.Code.Equals("AZ-100", StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        [Fact]
        public void GenerateSitemap()
        {
            StringBuilder sb = new StringBuilder();

            string baseAddress = "https://www.exam-answer.com";

            sb.Append($@"<?xml version=""1.0"" encoding=""UTF-8""?>
<urlset xmlns=""http://www.sitemaps.org/schemas/sitemap/0.9"">");

            sb.Append(@$"
<url>
  <loc>{baseAddress}</loc>
</url>");

            sb.Append(@$"
<url>
  <loc>{baseAddress}/contact</loc>
</url>");

            sb.Append(@$"
<url>
  <loc>{baseAddress}/about</loc>  
</url>");

            foreach (var exam in ExamsToCheck)
            {
                sb.Append(@$"
<url>
  <loc>{baseAddress}/{exam.Provider}/{exam.Code}</loc>
</url>");
            }

            foreach (var exam in ExamsToCheck)
            {
                for (int i = 1; i <= exam.Questions.Count; i++)
                {
                    sb.Append(@$"
<url>
  <loc>{baseAddress}/{exam.Provider}/{exam.Code}/question{i}</loc>
</url>");
                }
            }
            // <lastmod>2020-07-1T21:20:29+00:00</lastmod>
            sb.Append(@"
</urlset>");

            var res = sb.ToString().ToLowerInvariant(); //.Replace("2020-07-1t21:20:29+00:00", "2020-07-1T21:20:29+00:00");
            Debugger.Break();
        }

        [Fact]
        public void ReadPdf()
        {
            //var pdfDoc = PdfDocument.FromFile("gratisexam.com-Microsoft.Braindumps.AZ-900.v2019-05-23.by.Francesco.62q.pdf");

            //var text = pdfDoc.ExtractTextFromPage(1);
        }

        private string FormatTextToBeFirstCapitalEndInPeriod(string sourceText)
        {
            if (string.IsNullOrEmpty(sourceText))
            {
                return sourceText;
            }
            sourceText = sourceText.Trim();
            sourceText = sourceText[0].ToString().ToUpperInvariant() + sourceText.Substring(1);

            string lastLetter = sourceText[sourceText.Length - 1].ToString();

            if (lastLetter != "." && lastLetter != "?" && lastLetter != "!")
            {
                sourceText += ".";
            }

            return sourceText;
        }

        private void GenerateCS(List<QuestionEntity> questions)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                QuestionEntity question = questions[i];
                int currOrder = i + 1;

                StringBuilder sb = new StringBuilder();

                sb.Append(
                    $@"
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{{
    public partial class Az900
    {{
        public static QuestionEntity Q{i}Instance = new QuestionEntity()
        {{
            QuestionType = QuestionType.{question.QuestionType},
            Order = {question.Order},
            Section = ""{question.Section}"",
            Contents = new List<ContentEntity>()
            {{");

                foreach (ContentEntity content in question.Contents)
                {
                    sb.Append(
                    $@"
                new ContentEntity()
                {{
                    Text = ""{content.Text.Replace("\"", "\\\"")}"",
                }},");
                }

                sb.Append($@"
            }},
");

                sb.Append(
                    $@"
            Answers = new List<AnswerEntity>()
            {{");

                foreach (AnswerEntity answer in question.Answers)
                {
                    sb.Append(
                $@"
                new AnswerEntity()
                {{
                    Text = ""{answer.Text.Replace("\"", "\\\"")}"",
                    IsCorrect = {answer.IsCorrect.GetValueOrDefault().ToString().ToLowerInvariant()}
                }},");
                }

                sb.Append($@"
            }},
");

                sb.Append(
                  $@"
            Explanations = new List<ExplanationEntity>()
            {{");

                foreach (ExplanationEntity explanation in question.Explanations)
                {
                    sb.Append(
                $@"
                new ExplanationEntity()
                {{
                    Text = ""{explanation.Text.Replace("\"", "\\\"")}""
                }},");
                }

                sb.Append($@"
            }},
");

                sb.Append($@"
            References = new List<ReferenceEntity>()
            {{");

                foreach (ReferenceEntity reference in question.References)
                {
                    sb.Append(
                    $@"
                new ReferenceEntity()
                {{
                    Url = ""{reference.Url.Replace("\"", "\\\"")}"",
                }},");
                }

                sb.Append($@"
            }},
        }};
    }}
}}
"
                    );

                string textToWrite = sb.ToString();

                File.WriteAllText($"Q{currOrder}.cs", textToWrite);
            }
        }

        [Fact]
        public void ParseAz900()
        {
            List<QuestionEntity> questions = new List<QuestionEntity>();

            List<string> files = Directory.GetFiles("AZ-900", "*.txt").OrderBy(s => s).ToList();

            string savedDuplicates = File.ReadAllText("AZ-900\\az-900Duplicates.txt");
            List<string> splitsStrings = savedDuplicates.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<int> saveDuplicatesOrders = new List<int>();
            foreach (string s in splitsStrings)
            {
                saveDuplicatesOrders.Add(int.Parse(s));
            }

            List<int> questionsDuplicatesOrders = new List<int>();

            foreach (string path in files)
            {
                List<string> lines = File.ReadAllLines(path).ToList();

                lines = lines.Where(l => !string.IsNullOrEmpty(l?.Trim())).ToList();

                List<int> indexes = new List<int>();

                for (int i = 0; i < lines.Count; i++)
                {
                    string currLine = lines[i];
                    if (currLine.StartsWith("QUESTION "))
                    {
                        indexes.Add(i);
                    }
                }

                //var linesStartingWithQuestion = lines.Where(l => l.StartsWith("QUESTION ")).ToList();

                //foreach (var line in linesStartingWithQuestion)
                //{
                //    var index = lines.IndexOf(line);
                //    indexes.Add(index);
                //}
                //indexes.Add(lines.Count);

                //indexes = indexes.OrderBy(s => s).ToList();

                for (int i = 0; i < indexes.Count - 1; i++)
                {
                    int currentIndex = indexes[i];
                    int nextIndex = indexes[i + 1];
                    List<string> questionLines = lines.Skip(currentIndex).Take(nextIndex - currentIndex).ToList();

                    // Catch parsing errors here
                    if (questionLines.Count > 100)
                    {
                    }

                    // Fix missing : in Explanation

                    for (int currIndexLine = 0; currIndexLine < questionLines.Count; currIndexLine++)
                    {
                        string currLine = questionLines[currIndexLine];
                        if ("Explanation".Equals(currLine, StringComparison.InvariantCultureIgnoreCase))
                        {
                            questionLines[currIndexLine] = "Explanation:";
                        }
                    }

                    string answer1 = questionLines.FirstOrDefault(f => f.Trim().StartsWith("A."));

                    int indexOfFirstAnswer = questionLines.IndexOf(answer1);

                    List<string> linesWithContent = questionLines.Skip(1).Take(indexOfFirstAnswer - 1).ToList();

                    QuestionEntity questionEntity = new QuestionEntity();

                    foreach (string lineWithContent in linesWithContent)
                    {
                        questionEntity.Contents.Add(new ContentEntity()
                        {
                            Text = FormatTextToBeFirstCapitalEndInPeriod(lineWithContent)
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
                        string answerText1 = answer1.Replace("A. ", string.Empty).Trim();
                        answerText1 = FormatTextToBeFirstCapitalEndInPeriod(answerText1);

                        bool isCorrect1 = correctAnswers.Any(c => c.ToString() == "A");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText1, IsCorrect = isCorrect1 });
                    }

                    string answer2 = questionLines.FirstOrDefault(f => f.StartsWith("B."));
                    if (!string.IsNullOrEmpty(answer2))
                    {
                        string answerText2 = answer2.Replace("B. ", string.Empty).Trim();
                        answerText2 = FormatTextToBeFirstCapitalEndInPeriod(answerText2);

                        bool isCorrect2 = correctAnswers.Any(c => c.ToString() == "B");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText2, IsCorrect = isCorrect2 });
                    }

                    string answer3 = questionLines.FirstOrDefault(f => f.StartsWith("C."));
                    if (!string.IsNullOrEmpty(answer3))
                    {
                        string answerText3 = answer3.Replace("C. ", string.Empty).Trim();
                        answerText3 = FormatTextToBeFirstCapitalEndInPeriod(answerText3);

                        bool isCorrect3 = correctAnswers.Any(c => c.ToString() == "C");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText3, IsCorrect = isCorrect3 });
                    }

                    string answer4 = questionLines.FirstOrDefault(f => f.StartsWith("D."));
                    if (!string.IsNullOrEmpty(answer4))
                    {
                        string answerText4 = answer4.Replace("D. ", string.Empty).Trim();
                        answerText4 = FormatTextToBeFirstCapitalEndInPeriod(answerText4);

                        bool isCorrect4 = correctAnswers.Any(c => c.ToString() == "D");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText4, IsCorrect = isCorrect4 });
                    }

                    string answer5 = questionLines.FirstOrDefault(f => f.StartsWith("E."));
                    if (!string.IsNullOrEmpty(answer5))
                    {
                        string answerText5 = answer5.Replace("E. ", string.Empty).Trim();
                        answerText5 = FormatTextToBeFirstCapitalEndInPeriod(answerText5);

                        bool isCorrect5 = correctAnswers.Any(c => c.ToString() == "E");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText5, IsCorrect = isCorrect5 });
                    }

                    string answer6 = questionLines.FirstOrDefault(f => f.StartsWith("F."));
                    if (!string.IsNullOrEmpty(answer6))
                    {
                        string answerText6 = answer6.Replace("F. ", string.Empty).Trim();
                        answerText6 = FormatTextToBeFirstCapitalEndInPeriod(answerText6);

                        bool isCorrect6 = correctAnswers.Any(c => c.ToString() == "F");
                        questionEntity.Answers.Add(new AnswerEntity() { Text = answerText6, IsCorrect = isCorrect6 });
                    }

                    if (questionEntity.Answers.Count(a => a.IsCorrect.GetValueOrDefault()) > 1)
                    {
                        questionEntity.QuestionType = QuestionType.CheckBox;
                    }

                    string sectionLine = questionLines.FirstOrDefault(f => f.StartsWith("Section:"));
                    string sectionName = sectionLine.Replace("Section:", string.Empty).Replace("Explanation", string.Empty).Trim();

                    if (!sectionName.Contains("none", StringComparison.InvariantCultureIgnoreCase))
                    {
                        questionEntity.Section = sectionName;
                    }
                    questionEntity.Order = questions.Count + 1;

                    string references = questionLines.FirstOrDefault(f => f.Trim().StartsWith("References:"));
                    int indexOfReferences = -1;
                    if (references != null)
                    {
                        indexOfReferences = questionLines.IndexOf(references);

                        for (int refIndex = indexOfReferences; refIndex < questionLines.Count; refIndex++)
                        {
                            string refUrl = questionLines[refIndex].Replace("References:", string.Empty).Trim();

                            if (!string.IsNullOrEmpty(refUrl))
                            {
                                questionEntity.References.Add(new ReferenceEntity()
                                {
                                    Url = refUrl
                                });
                            }
                        }
                    }

                    string explanation = questionLines.FirstOrDefault(f => f.Trim().StartsWith("Explanation:"));
                    int indexOfExplanation = -1;
                    if (explanation != null)
                    {
                        indexOfExplanation = questionLines.IndexOf(explanation);

                        if (indexOfReferences != -1 && indexOfExplanation != -1)
                        {
                            for (int explIndex = indexOfExplanation; explIndex < indexOfReferences; explIndex++)
                            {
                                string explanationString = questionLines[explIndex].Replace("Explanation:", string.Empty).Trim();

                                if (!string.IsNullOrEmpty(explanationString) &&
                                    !"Explanation/Reference:".Equals(explanationString.Trim(), StringComparison.InvariantCultureIgnoreCase))
                                {
                                    questionEntity.Explanations.Add(new ExplanationEntity()
                                    {
                                        Text = explanationString
                                    });
                                }
                            }
                        }
                    }

                    questions.Add(questionEntity);
                }
            }

            List<double> distances = new List<double>();

            List<QuestionEntity> duplicateQuestions = new List<QuestionEntity>();
            List<string> duplicateQuestionsPairs = new List<string>();

            questions = questions.Where(q => q.Answers.Count > 0 && q.Contents.Count > 0).ToList();

            questions = questions.Where(q => !saveDuplicatesOrders.Any(d => d == q.Order)).ToList();

            GenerateCS(questions);

            for (int i = 0; i < questions.Count; i++)
            {
                QuestionEntity q1 = questions[i];

                for (int j = i + 1; j < questions.Count; j++)
                {
                    QuestionEntity q2 = questions[j];

                    string text1 = q1.ContentText + q1.AnswerText;
                    string text2 = q2.ContentText + q2.AnswerText;

                    double distance = LevenshteinDistance.CalculateSimilarity(text1, text2);
                    distances.Add(Math.Round(distance, 2));
                    if (distance > 0.9)
                    {
                        duplicateQuestionsPairs.Add($"q{q1.Order}_q{q2.Order}_d: {distance}");
                    }
                    if (distance > 0.9)
                    {
                        if (q1.ExplanationText.Length + q1.ReferenceText.Length >= q2.ExplanationText.Length + q2.ReferenceText.Length)
                        {
                            duplicateQuestions.Add(q2);
                            questionsDuplicatesOrders.Add(q2.Order.GetValueOrDefault());
                        }
                        else
                        {
                            duplicateQuestions.Add(q1);
                            questionsDuplicatesOrders.Add(q1.Order.GetValueOrDefault());
                        }
                    }
                }
            }
            distances = distances.OrderByDescending(d => d).ToList();
            questionsDuplicatesOrders = questionsDuplicatesOrders.Distinct().OrderBy(s => s).ToList();
            StringBuilder sbDuplicatesToSave = new StringBuilder();
            foreach (int d in questionsDuplicatesOrders)
            {
                sbDuplicatesToSave.Append($"{d},");
            }

            string toWrite = sbDuplicatesToSave.ToString();

            File.WriteAllText("AZ-900\\az-900Duplicates.txt", toWrite);
        }
    }
}