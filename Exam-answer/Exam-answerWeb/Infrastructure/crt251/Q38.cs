using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q38
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 38,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers is devising a separate sales methodology to upsell service contracts to its existing customer base.",
                },
                new ContentEntity()
                {
                    Text = "The company wants to track and report on these deals separately from other deals."
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
                    Text = "Create a custom field on opportunity to flag and report on these sales.",
                },
                new AnswerEntity()
                {
                    Text = "Create an opportunity record type and sales process for reporting on these deals.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a separate page layout and report to flag and report on these deals.",
                },
                new AnswerEntity()
                {
                    Text = "Add \"upsell\" as a stage and create a summary by opportunity stage.",
                },
            }
        };
    }
}