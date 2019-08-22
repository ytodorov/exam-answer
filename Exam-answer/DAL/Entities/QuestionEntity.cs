using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class QuestionEntity : SchemaOrgEntity
    {

        public ExamEntity Exam { get; set; }

        public int? ExamId { get; set; }

        public string Section { get; set; }

        public QuestionType QuestionType { get; set; } = QuestionType.RadioButon;

        public List<ContentEntity> Contents { get; set; }

        public List<AnswerEntity> Answers { get; set; }

        public List<ExplanationEntity> Explanations { get; set; }

        public List<ReferenceEntity> References { get; set; }

        [NotMapped]
        public int AnswerCountLd { get; set; }

        [NotMapped]
        public List<AnswerEntity> AcceptedAnswerLd { get; set; }

        [NotMapped]
        public List<AnswerEntity> SuggestedAnswerLd { get; set; }

        [NotMapped]
        public string QuestionText
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (Contents != null)
                {
                    foreach (ContentEntity content in Contents)
                    {
                        sb.Append(content.Text);
                        sb.Append(" ");
                    }
                }
                string result = sb.ToString().Trim();

                return result;
            }
        }

        [NotMapped]
        public string AnswerText
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (Contents != null)
                {
                    foreach (var answer in Answers)
                    {
                        sb.Append(answer.Text);
                        sb.Append(" ");
                    }
                }
                string result = sb.ToString().Trim();

                return result;
            }
        }

        [NotMapped]
        public string ExplanationText
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (Explanations != null)
                {
                    foreach (ExplanationEntity explanation in Explanations)
                    {
                        sb.Append(explanation.Text);
                        sb.Append(" ");
                    }
                }
                string result = sb.ToString().Trim();

                return result;
            }
        }

    }

}
