using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q98
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 98,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers has established a private sharing model for accounts and opportunities. Each sales manager has several sales representatives reporting to them and the Role Heirarchy is configured.",
                },
                new ContentEntity()
                {
                    Text = "Which statement about data visibility is true?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Both sales managers and representatives can see all of the same data.",
                },
                new AnswerEntity()
                {
                    Text = "The sales manager can see all of representative's data but the representative CANNOT see all of the sales manager's data.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "The representative can see all of sales manager's data but the Sales manager CANNOT see all of the representative's data.",                    
                },
                new AnswerEntity()
                {
                    Text = "Only the sales representatives can see all of the data.",
                },
            }
        };
    }
}