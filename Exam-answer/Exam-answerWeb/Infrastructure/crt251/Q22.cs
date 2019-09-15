using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q22
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 22,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers uses a seven-step selling methodology.",
                },
                new ContentEntity()
                {
                    Text = "Each sales stage corresponds with a step in the methodology."
                },
                new ContentEntity()
                {
                    Text = "The first stage is a preliminary qualification step, and opportunities in this stage should NOT contribute to the forecast."
                },
                new ContentEntity()
                {
                    Text = "Which two actions should a consultant recommend to meet these requirements? (Choose two.)"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Instruct sales users to enter 0S for the opportunity amount.",
                },
                new AnswerEntity()
                {
                    Text = "Configure the first stage with the omitted forecast category.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Override the forecast to be $0 for first stage opportunities.",
                },
                new AnswerEntity()
                {
                    Text = "Assign 0% probability to the first sales stage.",
                    IsCorrect = true
                },
            }
        };
    }
}