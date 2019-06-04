using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q73
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 73,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) needs to quickly look up contacts, accounts, and opportunities and easily log calls.",
                },
                new ContentEntity()
                {
                    Text = "The team wants access to customer information even without an Internet connection because of limited coverage in certain geographic areas.",
                },
                new ContentEntity()
                {
                    Text = "Which mobile solution should NTO use?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Salesforce App.",
                },
                new AnswerEntity()
                {
                    Text = "Salesforce Touch App.",                    
                },
                new AnswerEntity()
                {
                    Text = "Custom hybrid App.",                    
                },
                new AnswerEntity()
                {
                    Text = "Salesforce Mobile App.",
                    IsCorrect = true
                },
            }
        };
    }
}