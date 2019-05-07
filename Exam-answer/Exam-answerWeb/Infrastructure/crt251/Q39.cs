using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q39
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "The marketing department at Universal Containers is migrating from its legacy campaign and email management system to Salesforce and wants to ensure that its communication materials can be migrated as well.",
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to migrate the marketing department's email templates?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Enable Email-to-Close and use the Import Wizard.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create an email template change set or use the Lighting Platform.",
                },
                new AnswerEntity()
                {
                    Text = "Manually recreate the email and mail merge templates in Salesforce.",      
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Enable Email to Salesforce before sending email templates to Salesforce.",                   
                },
            }
        };
    }
}