using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Models
{
    public class ExplanationViewModel : BaseViewModel
    {
        public string Text { get; set; }

        public int? QuestionId { get; set; }

        public QuestionViewModel Question { get; set; }
    }
}
