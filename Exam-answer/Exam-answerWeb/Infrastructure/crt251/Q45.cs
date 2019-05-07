using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q45
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 45,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Computing is planning to implement salesforce sales cloud to support its professional services division.",
                },
                new ContentEntity()
                {
                    Text = "The universal computing sales team wants to easily see customer purchasing activity on account, contact, and contract detail pages.",
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to meet this requirement?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a global publisher action to view all customer purchasing activity.",
                },
                new AnswerEntity()
                {
                    Text = "Enable the orders object in Salesforce to track customer purchases.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Enable salesforce console for sales to see customer purchasing activity.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a custom object related to the account, contact and contact objects.",                    
                },
            }
        };
    }
}