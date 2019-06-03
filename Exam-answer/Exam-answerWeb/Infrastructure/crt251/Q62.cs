using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q62
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 62,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters' (NTO) consumer business has grown to more than 500,000 contacts.",
                },
                new ContentEntity()
                {
                    Text = "NTO stores all individual consumer contacts under a single account called \"Consumer.\" Mass updates are no longer completed within the defined maintenance timeframe and an increased number of errors are being reported.",
                },
                new ContentEntity()
                {
                    Text = "Which two actions should be recommended to improve performance?",
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
                    Text = "Enable person accounts and migrate the contact data.",
                },
                new AnswerEntity()
                {
                    Text = "Add an index to the account field on the contact object.",                    
                },
                new AnswerEntity()
                {
                    Text = "Remove the account assignment for all contacts.",                    
                },
                new AnswerEntity()
                {
                    Text = "Ensure that no single account has more than 10,000 contacts.",
                },
            }
        };
    }
}