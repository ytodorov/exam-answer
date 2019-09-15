using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q84
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 84,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = @"Northern Trail Outfitters has a lead qualification team that does the following:
* Qualifies opportunities
* Converts leads into opportunities",
                },
                new ContentEntity()
                {
                    Text = "During lead conversion, the new opportunity must be assigned to the account owner.",
                },
                new ContentEntity()
                {
                    Text = "What should be created in order to meet this requirement?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "An assignment rule on the account.",
                },
                new AnswerEntity()
                {
                    Text = "A trigger on the opportunity.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A workflow on the opportunity.",
                },
                new AnswerEntity()
                {
                    Text = "An assignment rule on the opportunity.",
                },
            }
        };
    }
}