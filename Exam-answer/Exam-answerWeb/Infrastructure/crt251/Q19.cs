using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q19
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 19,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers uses PDF documents to help the Sales Team learn about new Products.",
                },
                new ContentEntity()
                {
                    Text = "Which feature should a Consultant recommend to store these documents?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "File Sync.",
                },
                new AnswerEntity()
                {
                    Text = "Salesforce Files.",
                },
                new AnswerEntity()
                {
                    Text = "Attachments.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "File Contact for SharePoint.",
                },
            }
        };
    }
}