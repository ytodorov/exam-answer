using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q44
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 44,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What solution should consultant recommend to UC which needs to show a dashboard with forecast by product family with quotas?",
                },
                new ContentEntity()
                {
                    Text = "The company wants to track and report on these deals separately from other deals.",
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to meet this requirement?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Customize Quotas with product report and add necessary fields.",
                },
                new AnswerEntity()
                {
                    Text = "Build a joined report with closed opportunities, forecasting items, and quotas.",                   
                },
                new AnswerEntity()
                {
                    Text = "Build a custom report with closed forecasting quotas with forecasting items.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create an analytical snapshot to capture the opportunity forecast.",
                    IsCorrect = true
                },
            }
        };
    }
}