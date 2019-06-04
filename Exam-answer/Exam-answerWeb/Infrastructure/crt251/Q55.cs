using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q55
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 55,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Leads created from the \"Contact Us\" form on Northern Trail Outfitters' website are not being followed-up on in a timely manner.",
                },
                new ContentEntity()
                {
                    Text = "Management wants to be notified when a lead has NOT been followed-up within 24 hours of being submitted.",
                },
                new ContentEntity()
                {
                    Text = "Which action should be recommended?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Send an email using lead escalation rule.",
                },
                new AnswerEntity()
                {
                    Text = "Notify using Chatter on leads.",
                },
                new AnswerEntity()
                {
                    Text = "Notify using publisher action.",
                },
                new AnswerEntity()
                {
                    Text = "Send an email using time-based workflow.",
                    IsCorrect = true
                },
            }
        };
    }
}