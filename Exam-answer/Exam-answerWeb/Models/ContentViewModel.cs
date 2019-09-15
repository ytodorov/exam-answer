namespace Exam_answerWeb.Models
{
    public class ContentViewModel : BaseViewModel
    {
        public string Text { get; set; }

        public QuestionViewModel Question { get; set; }

        public int? QuestionId { get; set; }
    }
}