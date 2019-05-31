using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q96
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 96,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers was bought by a larger company and needs to provide information on a monthly basis to the new parent company to help predict sales.",
                },
                new ContentEntity()
                {
                    Text = "Which data should the new parent company review?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Dashboard of user login history.",
                },
                new AnswerEntity()
                {
                    Text = "Count of new lead records created.",                    
                },
                new AnswerEntity()
                {
                    Text = "Number of activities tied to opportunities",                    
                },
                new AnswerEntity()
                {
                    Text = "Opportunity pipeline report grouped by month",
                    IsCorrect = true
                },
            }
        };
    }
}