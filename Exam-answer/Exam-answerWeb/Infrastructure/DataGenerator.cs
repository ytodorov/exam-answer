using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Infrastructure
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExamAnswerContext(
                serviceProvider.GetRequiredService<DbContextOptions<ExamAnswerContext>>()))
            {
                ExamEntity crt251 = new ExamEntity()
                {
                    Questions = new List<QuestionEntity>()
                };

                crt251.Questions.Add(new QuestionEntity()
                {
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
                });

                crt251.Questions.Add(new QuestionEntity()
                {
                    QuestionType = QuestionType.CheckBox,
                    Contents = new List<ContentEntity>()
                    {
                        new ContentEntity()
                        {
                             Text = "Universal Containers’ current solution for managing its forecasts is cumbersome.",
                        },
                        new ContentEntity()
                        {
                            Text = "The sales managers do NOT have visibility into their teams’ forecasts and are NOT able to update the forecasts."
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
                });

                context.Exams.Add(crt251);
                context.SaveChanges();
            }
        }
    }
}
