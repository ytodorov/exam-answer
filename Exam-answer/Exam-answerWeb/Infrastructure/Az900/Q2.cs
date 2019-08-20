using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q2Instance = new QuestionEntity()
        {
            Order = 2,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASE text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "When planning to migrate a public website to Azure, you must plan to PAY MONTHLY USAGE COSTS."
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the UPPER-CASE text. If it makes the statement correct, select “No change is needed”. If the statement is incorrect, select the answer choice that makes the statement correct."
                },
                new ContentEntity()
                {
                    Text = ""
                }
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Deploy a VPN."
                },
                new AnswerEntity()
                {
                    Text = "Pay to transfer all the website data to Azure.",
                },
                new AnswerEntity()
                {
                    Text = "Reduce the number of connections to the website."
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
               
            },
            References = new List<ReferenceEntity>()
            {
               
            }
        };
    }
}