using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q66
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 66,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "How should a consultant configure Sales Cloud if a customer requires two unique sets of sales stages for opportunities based on the opportunity amount being greater than or less than $100,000 USD?",
                },
                new ContentEntity()
                {
                    Text = "As volume of leads has increased, NTO has noticed a decrease in satisfaction from partners on the quality of leads and a noticeable decrease in the lead conversion rate.",
                },
                 new ContentEntity()
                {
                    Text = "What should the consultant suggest in order to increase partner satisfaction with the leads being shared?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create two sales processes and a workflow rule triggered by opportunity amount to assign a sales process.",
                },
                new AnswerEntity()
                {
                    Text = "Create two sales processes, two opportunity record types, and a workflow rule triggered by sales stage.",
                },
                new AnswerEntity()
                {
                    Text = "Create two sales processes, two opportunity record types, and workflow rules triggered by the opportunity amount.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create one sales process and a validation rule that evaluates opportunity amount to determine the appropriate sales stage.",
                },
            }
        };
    }
}