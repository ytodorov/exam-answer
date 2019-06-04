using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q88
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 88,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A consultant wants to confirm requirements are collected during the project planning stage.",
                },
                new ContentEntity()
                {
                    Text = "Which three customer information data points should be requested?",
                },
                new ContentEntity()
                {
                    Text = "Choose 3 answers.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "List of stakeholders with roles and titles.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Key reports from the current system.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "List of required objects and fields.",
                },
                new AnswerEntity()
                {
                    Text = "Company financial information.",
                },
                new AnswerEntity()
                {
                    Text = "Organizational chart with titles.",
                    IsCorrect = true
                },
            }
        };
    }
}