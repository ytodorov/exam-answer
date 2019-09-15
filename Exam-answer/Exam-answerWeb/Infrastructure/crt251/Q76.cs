using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q76
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 76,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A Sales Cloud consultant is working on an implementation that has multi-currency, multi-language, and region-specific sales processes and workflows.",
                },
                new ContentEntity()
                {
                    Text = "Which two actions are essential for optimizing user adoption?",
                },
                new ContentEntity()
                {
                    Text = "Choose 2 answers.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Developing only a standardized, global training curriculum for all users.",
                },
                new AnswerEntity()
                {
                    Text = "Communicating the training plan well in advance of training start date.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Customizing the training curriculum for each specific region.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Employing realistic training data in the corporate standard currency.",
                },
            }
        };
    }
}