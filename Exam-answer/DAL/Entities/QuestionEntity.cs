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
               
    }
        
}
