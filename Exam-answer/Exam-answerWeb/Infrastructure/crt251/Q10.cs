using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q10
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers has a private sharing model and wants the ability to share documents related to an opportunity, such as contracts and proposals, with the field sales team.",
                },
                new ContentEntity()
                {
                    Text = "How can the documents be shard efficiently and securely?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The documents should be uploaded to Salesforce Files and shared with the field sales organization.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "The documents should be emailed to the sales team on the opportunity record.",                    
                },
                new AnswerEntity()
                {
                    Text = "The documents should be uploaded to Salesforce Files from the opportunity record.",
                },
                new AnswerEntity()
                {
                    Text = "The documents should be uploaded to a library that is shared with the field sales organization.",
                },
            }
        };
    }
}