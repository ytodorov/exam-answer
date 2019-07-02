using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Models
{
    public class ExamViewModel : BaseViewModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Provider { get; set; }

        public List<QuestionViewModel> Questions { get; set; }

        public string UdemyLinkUrl { get; set; }

        public string UdemyLinkMessage { get; set; }

        public string UdemyMessage { get; set; }

        public bool ShowUdemy { get; set; } = true;

    }
}
