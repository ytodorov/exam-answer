
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q59Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 161,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You need to limit the amount of inbound traffic to all the Azure virtual networks.",
                },
                new ContentEntity()
                {
                    Text = "What should you create?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "One network security group (NSG).", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "10 virtual network gateways.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "10 Azure ExpressRoute circuits.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "One Azure firewall.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Firewall is a managed, cloud-based network security service that protects your Azure Virtual Network resources. It's a fully stateful firewall-as-a-service with built-in high availability and unrestricted cloud scalability. You can centrally create, enforce, and log application and network connectivity policies across subscriptions and virtual networks."
                },
                new ExplanationEntity()
                {
                    Text = "Capabilities supported in Azure Firewall:"
                },
                new ExplanationEntity()
                {
                    Text = "Stateful firewall as a service"
                },
                new ExplanationEntity()
                {
                    Text = "Built-in high availability with unrestricted cloud scalability"
                },
                new ExplanationEntity()
                {
                    Text = "FQDN filtering"
                },
                new ExplanationEntity()
                {
                    Text = "FQDN tags"
                },
                new ExplanationEntity()
                {
                    Text = "Network traffic filtering rules"
                },
                new ExplanationEntity()
                {
                    Text = "Outbound SNAT support"
                },
                new ExplanationEntity()
                {
                    Text = "Inbound DNAT support"
                },
                new ExplanationEntity()
                {
                    Text = "Centrally create, enforce, and log application and network connectivity policies across Azure subscriptions and VNETs"
                },
                new ExplanationEntity()
                {
                    Text = "Fully integrated with Azure Monitor for logging and analytics"
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="What is Azure Firewall?",
                    Url = "https://docs.microsoft.com/en-us/azure/firewall/overview"
                },
                new ReferenceEntity()
                {
                    Text ="Azure Firewall FAQ",
                    Url = "https://docs.microsoft.com/en-us/azure/firewall/firewall-faq"
                },
            },                
        };
    }
}
