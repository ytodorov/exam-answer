namespace Exam_answerWeb.Models
{
    public class ReferenceViewModel : BaseViewModel
    {
        public string Text { get; set; }

        public string Url { get; set; }

        public QuestionViewModel Question { get; set; }

        public int? QuestionId { get; set; }
    }
}