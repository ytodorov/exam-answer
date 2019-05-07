using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q27
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "The sales representatives at Universal Containers use various email applications and often receive important customer emails where they are away from the office.",
                },
                new ContentEntity()
                {
                    Text = "Sales management wants to ensure sales representatives are recording email activity with customers in Salesforce while they are away from the office."
                },
                new ContentEntity()
                {
                    Text = "Which solution should a consultant recommend to meet this requirement?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Download and install a Salesforce universal connector for their smartphones and computers.",                    
                },
                new AnswerEntity()
                {
                    Text = "Download and install the Salesforce for Outlook connector on their smartphones and computers.",                    
                },
                new AnswerEntity()
                {
                    Text = "Forward emails using their Email-to-Salesforce email address from their smartphones and computers.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Copy and paste emails manually to the customer record in Salesforce from their smartphones and computers.",                    
                },
            }
        };
    }
}