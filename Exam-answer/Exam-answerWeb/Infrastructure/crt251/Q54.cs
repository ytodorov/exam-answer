using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q54
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 54,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A consultant is recommending Salesforce Console for Sales to Northern Trail Outfitters to improve sales productivity in inside sales.",
                },
                new ContentEntity()
                {
                    Text = "Which two use cases support this recommendation?",
                },
                new ContentEntity()
                {
                    Text = "Choose 2 answers.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Need to prioritize search results for contacts and opportunities.",
                },
                new AnswerEntity()
                {
                    Text = "Need to add notes quickly while talking to the client.",       
                    IsCorrect  = true                    
                },
                new AnswerEntity()
                {
                    Text = "Need to chat with customers in real time with Chatter.",                    
                },
                new AnswerEntity()
                {
                    Text = "Need to view the caller ID on screen and quickly make calls with one click.",
                    IsCorrect = true
                },
            }
        };
    }
}