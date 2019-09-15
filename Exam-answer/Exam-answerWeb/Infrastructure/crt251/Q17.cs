using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q17
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 17,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers wants to track the campaigns that influence won opportunities.",
                },
                new ContentEntity()
                {
                    Text = "Which two actions should a consultant recommend to meet this requirement using standard functionality? (Choose two.) "
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Have the administrator specify a timeframe that limits the time a campaign can influence an opportunity after the campaign first associated date and before the opportunity created date.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Automatically add child campaigns of the primary campaign source if the child campaigns have an end date that fails before the opportunity close date.",
                },
                new AnswerEntity()
                {
                    Text = "Add campaigns to opportunities when the campaign is related to a contact that is assigned a contact role on the opportunity prior to the close date.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Have representatives populate a field on the opportunity record with the dollar amount of the expected revenue from the campaigns that influenced the opportunity.",
                },
            }
        };
    }
}