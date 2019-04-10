using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Models
{
    public class SearchQuestionViewModel
    {
        public string Title { get; set; }

        public string ExamName { get; set; }

        public string ExamProvider { get; set; }

        public string Content { get; set; }

        public string FilePath { get; set; }

        public string TextInUI { get; set; }
    }
}
