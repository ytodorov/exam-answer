using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q23
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A premier customer for Universal Containers needs access to confidential product roadmap information.",
                },
                new ContentEntity()
                {
                    Text = "Which two steps should a sales representative take to securely send this information using content delivery? (Choose two.)"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Remove access to content after a specified date.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Require the customer to enter a password to view the content.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Require the customer to enter a security token to download the content.",                    
                },
                new AnswerEntity()
                {
                    Text = "Require the recipient to log into Salesforce to access the content.",                    
                },
            }
        };
    }
}