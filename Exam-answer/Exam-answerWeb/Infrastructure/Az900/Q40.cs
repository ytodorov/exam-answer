using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q39Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 50,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What is required to use Azure Cost Management?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A Dev/Test subscription.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Software Assurance.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Enterprise Agreement (EA).",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A pay-as-you-go subscription.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "As enterprises accelerate cloud adoption, it is becoming increasingly important to manage cloud costs across the organization. Last September, we announced the public preview of a comprehensive native cost management solution for enterprise customers. We are now excited to announce the general availability (GA) of Azure Cost Management experience that helps organizations visualize, manage, and optimize costs across Azure."
                },
                new ExplanationEntity()
                {
                    Text = "In addition, we are excited to announce the public preview for web direct Pay-As-You-Go customers and Azure Government cloud."
                },
                new ExplanationEntity()
                {
                    Text = "With the addition of the Azure Cost Management, customers now have an always-on, low-latency solution to understand and visualize costs with the following features available in Cost Management:"
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure Cost Management now generally available for enterprise agreements and more!",
                    Url = "https://azure.microsoft.com/en-in/blog/azure-cost-management-now-general-availability-for-enterprise-agreements-and-more/"
                },
                new ReferenceEntity()
                {
                    Text = "What is Azure Cost Management?",
                    Url = "https://docs.microsoft.com/en-gb/azure/cost-management/overview-cost-mgt",
                },
            },
        };
    }
}