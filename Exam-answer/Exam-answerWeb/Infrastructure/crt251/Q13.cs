using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q13
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers is moving from a legacy customer relationship management (CRM) system to Salesforce Sales Cloud.",
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to ensure a successful implementation?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Review the current system with all levels of users to understand their requirements.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Review the current system with executive management to understand their requirements.",                    
                },
                new AnswerEntity()
                {
                    Text = "Review the current system with IT management to understand their requirements.",                    
                },
                new AnswerEntity()
                {
                    Text = "Review the current system and configure Sales Cloud to work in the same way.",
                },
            }
        };
    }
}