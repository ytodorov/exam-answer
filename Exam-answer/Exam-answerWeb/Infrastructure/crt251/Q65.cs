using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q65
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 65,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters' Board of Directors thinks that sales user adoption should be calculated by the number of daily logins.",
                },
                new ContentEntity()
                {
                    Text = "Which two measures of sales user adoption should be considered when implementing Sales Cloud?",
                },
                new ContentEntity()
                {
                    Text = "Choose 2 answers.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Overall effectiveness of mass email campaigns.",
                },
                new AnswerEntity()
                {
                    Text = "Number of neglected opportunities over time by role.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Completeness of records entered into the new system.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Number of reports exported to Excel for analysis.",
                },
            }
        };
    }
}