using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q52
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 52,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A sales manager wants a report that all activities in the manager's accounts, including contacts and opportunities.",
                },
                new ContentEntity()
                {
                    Text = "Which report should the sales manager use?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Activities report on accounts the manager owns.",                    
                },
                new AnswerEntity()
                {
                    Text = "Activities report on accounts and contacts the manager owns.",                   
                },
                new AnswerEntity()
                {
                    Text = "Activities report on accounts and opportunities the manager owns.",                    
                },
                new AnswerEntity()
                {
                    Text = "Activities report on accounts, contacts, and opportunities the manager owns.",     
                    IsCorrect = true
                },
            }
        };
    }
}