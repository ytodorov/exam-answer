using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q1Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 1,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What are two characteristics of the public cloud? Each correct answer presents a complete solution.",
                },
                new ContentEntity()
                {
                    Text = "NOTE: Each correct selection is worth one point.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Dedicated hardware.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Unsecured connections.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Limited storage.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Metered pricing.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Self-service management.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Advantages of public clouds:"
                },
                new ExplanationEntity()
                {
                    Text = "Lower costs—no need to purchase hardware or software, and you pay only for the service you use."
                },
                new ExplanationEntity()
                {
                    Text = "No maintenance—your service provider provides the maintenance."
                },
                new ExplanationEntity()
                {
                    Text = "Near-unlimited scalability—on-demand resources are available to meet your business needs."
                },
                new ExplanationEntity()
                {
                    Text = "High reliability—a vast network of servers ensures against failure."
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Public Cloud vs Private Cloud vs Hybrid Cloud",
                    Url = "https://azure.microsoft.com/en-us/overview/what-are-private-public-hybrid-clouds/"
                },
                new ReferenceEntity()
                {
                    Text = "What is a Public Cloud - Definition",
                    Url = "https://azure.microsoft.com/en-us/overview/what-is-a-public-cloud/"
                }
            },
        };
    }
}