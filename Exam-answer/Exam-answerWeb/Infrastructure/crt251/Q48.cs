using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q48
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 48,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to meet this requirement?",
                },
                new ContentEntity()
                {
                    Text = "Universal Containers has a private sharing model for accounts and opportunities.",
                },
                new ContentEntity()
                {
                    Text = "Each sales representative is assigned to work a dedicated sales engineer.",
                },
                new ContentEntity()
                {
                    Text = "The sales engineer will need access to their assigned sales representatives' accounts and opportunities.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a trigger to add the sales engineers to their sales representatives account and opportunity teams.",                   
                },
                new AnswerEntity()
                {
                    Text = "Create criteria-based sharing rules to share the accounts and opportunities with sales engineers.",                    
                },
                new AnswerEntity()
                {
                    Text = "Enable account and opportunity teams selling and have each sales representative configure their default teams.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Have the sales representatives manually share the accounts and opportunities with their assigned sales engineers.",                    
                },
            }
        };
    }
}