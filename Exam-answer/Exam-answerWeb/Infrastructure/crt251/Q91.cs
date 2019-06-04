using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q91
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 91,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) wants to utilize opportunities to track and report customer subscriptions to its online magazine.",
                },
                new ContentEntity()
                {
                    Text = @"Payments can be made using the following methods:
* In full (all at one time)
* Weekly
* Monthly
* Quarterly.",
                },
                new ContentEntity()
                {
                    Text = "How should this solution be implemented?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Use contracts with a lookup to opportunity object.",
                },
                new AnswerEntity()
                {
                    Text = "Enable schedules on opportunity object.",                    
                },
                new AnswerEntity()
                {
                    Text = "Enable schedules on product object.",                 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Use assets with a lookup to opportunity object.",
                },
            }
        };
    }
}