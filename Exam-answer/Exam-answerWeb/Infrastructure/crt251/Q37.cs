using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q37
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 37,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A consultant has created a custom formula field on Opportunity that multiples the Opportunity Amount by the Accounts Discount field.",
                },
                new ContentEntity()
                {
                    Text = "Which Currency will the formula field use for its value if the Opportunity and the Account records have different Currencies?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The Account currency.",
                },
                new AnswerEntity()
                {
                    Text = "The User currency.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "The Corporate currency.",
                },
                new AnswerEntity()
                {
                    Text = "The Opportunity currency.",
                },
            }
        };
    }
}