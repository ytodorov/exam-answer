using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q85
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 85,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters' sales manager noticed the lead conversion ratio stayed the same for the healthcare industry even though the lead creation increased.",
                },
                new ContentEntity()
                {
                    Text = "Which reporting tool should resolve the issue?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Industry performance dashboard.",
                },
                new AnswerEntity()
                {
                    Text = "Campaign dashboard by industry.",                    
                },
                new AnswerEntity()
                {
                    Text = "Report on leads by source.",                    
                },
                new AnswerEntity()
                {
                    Text = "Report on lead lifetime by industry.",
                    IsCorrect = true
                },
            }
        };
    }
}