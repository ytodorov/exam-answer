using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q2
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 2,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
                    {
                        new ContentEntity()
                        {
                             Text = "Universal Containers' current solution for managing its forecasts is cumbersome.",
                        },
                        new ContentEntity()
                        {
                            Text = "The sales managers do NOT have visibility into their teams' forecasts and are NOT able to update the forecasts."
                        },
                        new ContentEntity()
                        {
                            Text = "As a result, the managers are continually asking their sales representatives to provide updated forecast data via email or phone."
                        },
                        new ContentEntity()
                        {
                            Text = "Which two solutions should a consultant recommend to help Universal Containers improve the management of their forecasts? (Choose two.)"
                        }
                    },
            Answers = new List<AnswerEntity>()
                    {
                        new AnswerEntity()
                        {
                            Text = "Enable override forecast permission in the Manager's profile.",
                            IsCorrect = true
                        },
                        new AnswerEntity()
                        {
                            Text = "Configure weekly customized forecast reports and dashboards to be emailed to sales management."
                        },
                        new AnswerEntity()
                        {
                            Text = "Create a forecast hierarchy and assign managers to the forecast manager role.",
                            IsCorrect = true
                        },
                        new AnswerEntity()
                        {
                            Text = "Create forecast Chatter groups where sales representatives can post and share their forecasts.",
                        },
                    }
        };
    }
}