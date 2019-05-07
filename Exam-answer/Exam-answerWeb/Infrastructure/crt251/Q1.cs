using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q1
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 1,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers is planning to hire more sales representatives in response to three consecutive quarters of rapid growth.",
                },
                new ContentEntity()
                {
                    Text = "To optimize their sales impact, the sales management team wants to develop a better sales territory structure."
                },
                new ContentEntity()
                {
                    Text = "Which two data points should the sales management team consider when developing the new sales territories? (Choose two.)"
                }
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Attributes needed to segment and categorize customers.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Distance between customer headquarters and their sales representatives."
                },
                new AnswerEntity()
                {
                    Text = "Average number of customers managed by a sales representative."
                },
                new AnswerEntity()
                {
                    Text = "Number of currencies needed to support each sales territory.",
                    IsCorrect = true
                },
            }
        };
    }
}