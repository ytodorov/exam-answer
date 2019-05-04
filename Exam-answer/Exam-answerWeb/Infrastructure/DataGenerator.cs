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
                ExamEntity crt251 = new ExamEntity();
                crt251.Questions.Add(new QuestionEntity()
                {
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
            }
        }
    }
}
