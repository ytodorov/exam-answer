using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q24Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 24,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You need to configure an Azure solution that meets the following requirements:.",
                },
                new ContentEntity()
                {
                    Text = "Secures websites from attacks.",
                },
                new ContentEntity()
                {
                    Text = "Generates reports that contain details of attempted attacks.",
                },
                new ContentEntity()
                {
                    Text = "What should you include in the solution?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Firewall.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A network security group (NSG).",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Information Protection.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "DDoS protection.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Distributed denial of service (DDoS) attacks are some of the largest availability and security concerns facing customers that are moving their applications to the cloud. A DDoS attack attempts to exhaust an application's resources, making the application unavailable to legitimate users. DDoS attacks can be targeted at any endpoint that is publicly reachable through the internet."
                },
                new ExplanationEntity()
                {
                    Text = "Product features:"
                },
                new ExplanationEntity()
                {
                    Text = "Always-on monitoring and automatic network attack mitigation"
                },
                new ExplanationEntity()
                {
                    Text = "Adaptive tuning based on platform insights in Azure"
                },
                 new ExplanationEntity()
                {
                    Text = "Application layer protection with Azure Application Gateway Web Application Firewall"
                },
                new ExplanationEntity()
                {
                    Text = "Integration with Azure Monitor for analytics and insights"
                },
                 new ExplanationEntity()
                {
                    Text = "Protection against the unforeseen costs of a DDoS attack"
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure DDoS Protection",
                    Url = "https://azure.microsoft.com/en-us/services/ddos-protection/"
                },
                new ReferenceEntity()
                {
                    Text = "Azure DDoS Protection Standard overview",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/ddos-protection-overview"
                },
            },
        };
    }
}