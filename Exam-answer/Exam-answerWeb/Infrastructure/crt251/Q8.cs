using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q8
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers sells three unique products and each product has its own sales process.",
                },
                new ContentEntity()
                {
                    Text = "The company qualifies prospects for the three products in a consistent manner; however, once the customer has shown interest, the sales representatives must follow the relevant products sales process."
                },
                 new ContentEntity()
                {
                    Text = "Which two solutions should a consultant recommend to meet these requirements? (Choose two.)"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Configure opportunity record types for each sales process.",
                },
                new AnswerEntity()
                {
                    Text = "Create sales stages that align with opportunity record types.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Define sales processes to map to each opportunity record type.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Define the default opportunity teams for each opportunity record type.",
                },
            }
        };
    }
}