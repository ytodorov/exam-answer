using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q9
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 9,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers has a public sharing model for accounts and uses the parent account field to create a multi-level account hierarchy.",
                },
                new ContentEntity()
                {
                    Text = "When viewing a parent account, the company wants to see the total value of open opportunities for all accounts in the hierarchy."
                },
                 new ContentEntity()
                {
                    Text = "Which solution should a consultant recommend to meet this requirement?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Use Apex to update a custom field on the parent account with the total value of open opportunities form the child accounts.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a roll-up summary field on the parent account showing the total value of open opportunities from the child accounts.",
                },
                new AnswerEntity()
                {
                    Text = "Define a workflow rule to update the custom field on the parent account with the total value of open opportunities from the child accounts.",
                },
                new AnswerEntity()
                {
                    Text = "Create a link on the account that opens a report showing the total value of open opportunities for all accounts in the hierarchy.",
                },
            }
        };
    }
}