﻿namespace Exam_answerWeb.Models
{
    public class AnswerViewModel : BaseViewModel
    {
        public string Text { get; set; }

        public bool? IsCorrect { get; set; }

        public QuestionViewModel Question { get; set; }

        public int? QuestionId { get; set; }
    }
}