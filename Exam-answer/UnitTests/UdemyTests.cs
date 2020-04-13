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
    public class UdemyTests
    {
        [Fact]
        public void CreateExportForUdemyTest()
        {
            List<ExamEntity> exams = DataGenerator.Initialize(null);

            ExamEntity theExamToExportToUdemy = exams.FirstOrDefault(f => f.Code == "AZ-900");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Question,Question Type (multiple-choice or multi-select),Answer Option 1,Answer Option 2,Answer Option 3,Answer Option 4,Answer Option 5,Answer Option 6,Correct Response,Explanation,Knowledge Area");

            List<QuestionEntity> theQuestions = theExamToExportToUdemy.Questions.Skip(50).Take(50).ToList();

            foreach (QuestionEntity question in theQuestions)
            {
                if (!question.Answers.Any(a => a.IsCorrect == true))
                {
                    continue;
                }

                sb.Append(question.ContentTextUdemy.Replace("\"", "\"\"").Replace(",", ""));
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
                    sb.Append(question.ExplanationTextUdemy.Replace(",", ""));
                    sb.Append("References: ");
                    sb.Append(question.ReferenceTextUdemy.Replace(",", ""));
                }

                sb.Append(",");

                string knowledgeArea = question.Section.Replace(",", "");

                sb.Append(knowledgeArea);

                sb.Append(Environment.NewLine);
            }

            string result = sb.ToString();

            File.WriteAllText($"BulkImportUdemy{theExamToExportToUdemy.Code}.csv", result);
        }
    }
}
