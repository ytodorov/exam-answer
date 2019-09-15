using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q97
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 97,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "When the billing address on an account is changed, the mailing address of all related contact records should be updated to reflect the new address.",
                },
                new ContentEntity()
                {
                    Text = "How can this requirement be met?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a workflow rule on accounts.",
                },
                new AnswerEntity()
                {
                    Text = "Create a workflow rule on contacts.",
                },
                new AnswerEntity()
                {
                    Text = "Create a process on accounts using Process Builder.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a Force.com trigger on contacts.",
                },
            }
        };
    }
}