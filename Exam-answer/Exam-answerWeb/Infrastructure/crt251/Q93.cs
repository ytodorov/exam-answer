using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q93
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 93,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters wants a visual representation in the Salesforce Mobile App of each account's sales by month.",
                },
                new ContentEntity()
                {
                    Text = "What should be recommended?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a Visualforce page with an embedded chart component for each account.",
                },
                new AnswerEntity()
                {
                    Text = "Create a dashboard component and use a Chatter feed on the account in Salesforce.",                    
                },
                new AnswerEntity()
                {
                    Text = "Embed a chart on the account page and use a custom link to filter by account.",                    
                },
                new AnswerEntity()
                {
                    Text = "Embed a chart on the account page; no other customization is needed.",
                    IsCorrect = true
                },
            }
        };
    }
}