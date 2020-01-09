using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Models
{
    public class QuestionViewModel : SchemaOrgViewModel
    {
        public ExamViewModel Exam { get; set; }

        public int? ExamId { get; set; }

        public string Section { get; set; }

        public QuestionType QuestionType { get; set; }

        public List<ContentViewModel> Contents { get; set; }

        public List<AnswerViewModel> Answers { get; set; }

        public List<ExplanationViewModel> Explanations { get; set; }

        public List<ReferenceViewModel> References { get; set; }

        public int AnswerCountLd { get; set; }

        public List<AnswerViewModel> AcceptedAnswerLd { get; set; }

        public List<AnswerViewModel> SuggestedAnswerLd { get; set; }

        public bool ShowDisqus { get; set; } = false;

        public string AcceptedAnswer { get; set; }
    }
}