using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q31
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 31,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers' management wants to see forecast numbers by all sales representatives and by multiple product groups.",
                },
                new ContentEntity()
                {
                    Text = "Which two actions should a consultant recommend to meet these requirements? (Choose two.)",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Implement Collaborative Forecasting with product family.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Build a custom forecast report showing product groups.",
                },
                new AnswerEntity()
                {
                    Text = "Build a forecast list view by product family group.",
                },
                new AnswerEntity()
                {
                    Text = "Implement Collaborative Forecasting with quota attainment.",
                    IsCorrect = true
                },
            }
        };
    }
}