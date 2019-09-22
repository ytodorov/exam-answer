using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q98Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 231,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription that contains a virtual network named VNet1. VNet1 contains four subnets named Gateway, Perimeter, NVA, and Production.",
                },
                new ContentEntity()
                {
                    Text = "The NVA subnet contains two network virtual appliances (NVAs) that will perform network traffic inspection between the Perimeter subnet and the Production subnet.",
                },
                new ContentEntity()
                {
                    Text = "You need to implement an Azure load balancer for the NVAs. The solution must meet the following requirements:.",
                },
                new ContentEntity()
                {
                    Text = "* The NVAs must run in an active-active configuration that uses automatic failover.",
                },
                new ContentEntity()
                {
                    Text = "* The NVAs must load balance traffic to two services on the Production subnet. The services have different IP addresses.",
                },
                new ContentEntity()
                {
                    Text = "Which three actions should you perform? Each correct answer presents part of the solution.",
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
                    Text = "Add two load balancing rules that have HA Ports enabled and Floating IP disabled.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Add a frontend IP configuration, two backend pools, and a health probe.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Add two load balancing rules that have HA Ports and Floating IP enabled.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Deploy a standard load balancer.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Deploy a basic load balancer.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Add a frontend IP configuration a backend pool, and a health probe.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "A standard load balancer is required for the HA ports."
                },
                new ExplanationEntity()
                {
                    Text = "Two backend pools are needed as there are two services with different IP addresses."
                },
                new ExplanationEntity()
                {
                    Text = "Floating IP rule is used where backend ports are reused."
                },
                new ExplanationEntity()
                {
                    Text = "HA Ports are not available for the basic load balancer."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure Standard Load Balancer overview",
                    Url = "https://docs.microsoft.com/en-us/azure/load-balancer/load-balancer-standard-overview",
                },
                new ReferenceEntity()
                {
                    Text = "Multiple Frontends for Azure Load Balancer",
                    Url = "https://docs.microsoft.com/en-us/azure/load-balancer/load-balancer-multivip-overview",
                },
            },
        };
    }
}