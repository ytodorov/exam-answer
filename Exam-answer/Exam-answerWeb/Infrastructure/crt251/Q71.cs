using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q71
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 71,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Management at Northern Trail Outfitters wants to make sure their sales representatives are recording important email communication with customers while they are away from their offices.",
                },                
                new ContentEntity()
                {
                    Text = "The sales representatives use various email applications.",
                },
                 new ContentEntity()
                {
                    Text = "Which solution should be recommended?",
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
                    Text = "Copy and paste emails manually to the customer record in Salesforce from their smartphones and computers.",                    
                },
                new AnswerEntity()
                {
                    Text = "Download and install the Salesforce for Outlook connector on their smartphones and computers.",                    
                },
                new AnswerEntity()
                {
                    Text = "Forward emails using their Email-to-Salesforce email address from their smartphones and computers.",
                },
            }
        };
    }
}