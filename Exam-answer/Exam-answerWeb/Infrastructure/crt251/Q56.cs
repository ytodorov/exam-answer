using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q56
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 56,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) has over 20,000 Accounts and 75,000 Contacts.",
                },
                new ContentEntity()
                {
                    Text = "NTO wants to ensure the customer data is accurate and that the customers are still currently at their respective companies.",
                },
                new ContentEntity()
                {
                    Text = "How can this be confirmed?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Use a data cleansing tool and the Stay-in-Touch feature of Salesforce to email contacts.",
                },
                new AnswerEntity()
                {
                    Text = "Create a workflow rule to mass email the contacts and capture any email bounces.",
                },
                new AnswerEntity()
                {
                    Text = "Use a data enrichment tool to verify account and contact data is up-to-date.",
                },
                new AnswerEntity()
                {
                    Text = "Create a workflow rule for the account and contact owner to confirm contact data.",
                },
            }
        };
    }
}