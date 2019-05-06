using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q4
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers forecasts and closes business monthly, and it needs to store details of open opportunities weekly.",
                },
                new ContentEntity()
                {
                    Text = "The sales management team wants to analyze how the sales funnel is changing throughout the month."
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to meet this requirement?"
                },
            },
            Answers = new List<AnswerEntity>()
             {
                 new AnswerEntity()
                 {
                     Text = "Schedule a custom forecast report to run weekly and store the results in a custom report folder.",
                      IsCorrect = true
                  },
                        new AnswerEntity()
                        {
                            Text = "Create a reporting snapshot to run daily and store the results in a custom object.",
                        },
                        new AnswerEntity()
                        {
                            Text = "Create a reporting snapshot to run weekly and store the results in a custom object.",
                        },
                        new AnswerEntity()
                        {
                            Text = "Schedule a custom forecast report to run daily and store the results in a custom report folder.",
                        },
            }
        };
    }
}