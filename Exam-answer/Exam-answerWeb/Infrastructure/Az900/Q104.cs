using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q103Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 239,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have a public load balancer that balances ports 80 and 443 across three virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "You need to direct all the Remote Desktop Protocol (RDP) connections to VM3 only.",
                },
                new ContentEntity()
                {
                    Text = "What should you configure?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "An inbound NAT rule.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A load balancing rule.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A new public load balancer for VM3.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A frontend IP configuration.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Create an inbound NAT port-forwarding rule:"
                },
                new ExplanationEntity()
                {
                    Text = "Create a load balancer inbound network address translation (NAT) rule to forward traffic from a specific port of the front-end IP address to a specific port of a back-end VM."
                },
                new ExplanationEntity()
                {
                    Text = "1. Select All resources in the left-hand menu, and then select MyLoadBalancer from the resource list."
                },
                new ExplanationEntity()
                {
                    Text = "2. Under Settings, select Inbound NAT rules, and then select Add.",
                },
                new ExplanationEntity()
                {
                    Text = "3. On the Add inbound NAT rule page, type or select the following values:",
                },
                new ExplanationEntity()
                {
                    Text = "* Name: Type MyNATRuleVM1.",
                },
                new ExplanationEntity()
                {
                    Text = "* Port: Type 4221.",
                },
                new ExplanationEntity()
                {
                    Text = "* Target virtual machine: Select MyVM1 from the drop-down.",
                },
                new ExplanationEntity()
                {
                    Text = "* Port mapping: Select Custom.",
                },
                new ExplanationEntity()
                {
                    Text = "* Target port: Type 3389.",
                },
                new ExplanationEntity()
                {
                    Text = "4. Select OK.",
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Tutorial: Configure port forwarding in Azure Load Balancer using the portal",
                    Url = "https://docs.microsoft.com/en-us/azure/load-balancer/tutorial-load-balancer-port-forwarding-portal",
                },
                new ReferenceEntity()
                {
                    Text = "Azure Load Balancer For RDP",
                    Url = "https://pixelrobots.co.uk/2017/08/azure-load-balancer-for-rds/",
                },
            },
        };
    }
}