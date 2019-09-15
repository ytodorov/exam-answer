using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q21
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 21,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers has its sales representatives enter a new lead whenever they are prospecting a new customer.",
                },
                new ContentEntity()
                {
                    Text = "After qualifying the new lead, a new opportunity must be created to track the deal."
                },
                new ContentEntity()
                {
                    Text = "Which three actions should a consultant recommend to enforce data quality and accuracy? (Choose three.)"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Enable validation rules on the opportunity.",
                },
                new AnswerEntity()
                {
                    Text = "Map custom lead fields to corresponding custom opportunity fields.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create an Apex trigger to perform data quality checks.",
                },
                new AnswerEntity()
                {
                    Text = "Enable validation rules on the lead.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Enable the lead conversion permission.",
                    IsCorrect = true
                },
            }
        };
    }
}