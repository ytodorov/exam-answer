using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q25
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers is planning to implement Salesforce Sales Cloud to support its professional services division.",
                },
                new ContentEntity()
                {
                    Text = "The Universal Containers sales team wants to easily see customer purchasing activity on account, contact, and contact detail pages."
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to meet this requirement?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Enable Salesforce Console for Sales to see customer purchasing activity.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a global publisher action to view all customer purchasing activity.",                    
                },
                new AnswerEntity()
                {
                    Text = "Enable the Orders object in Salesforce to track customer purchases.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a custom object related to the account, contact, and contract objects.",                    
                },
            }
        };
    }
}