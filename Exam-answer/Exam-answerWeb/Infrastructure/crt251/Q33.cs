using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q33
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers has a customer base of over 15,000 Accounts and 60,000 Contacts.",
                },
                new ContentEntity()
                {
                    Text = "The marketing manager wants to use the customer data for an upcoming new product launch but is concerned contacts may have moved to different companies."
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to ensure customer data is accurate?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Use a data cleansing tool and the Stay-in-Touch feature of Salesforce to email contacts.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a workflow rule for an account and contact owner to confirm contact data.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a workflow rule to mass email the contacts and capture any email bounces.",                   
                },
                new AnswerEntity()
                {
                    Text = "Use a data enrichment tool to verify account and contact data is up-to-date.",                    
                },
            }
        };
    }
}