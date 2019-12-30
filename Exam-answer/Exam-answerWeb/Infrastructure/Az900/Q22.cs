using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q22Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 22,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to move several servers to Azure.",
                },
                new ContentEntity()
                {
                    Text = "The company’s compliance policy states that a server named FinServer must be on a separate network segment.",
                },
                new ContentEntity()
                {
                    Text = "You are evaluating which Azure services can be used to meet the compliance policy requirements.",
                },
                new ContentEntity()
                {
                    Text = "Which Azure solution should you recommend?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A resource group for FinServer and another resource group for all the other servers.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A virtual network for FinServer and another virtual network for all the other servers.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A VPN for FinServer and a virtual network gateway for each other server.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "One resource group for all the servers and a resource lock for FinServer.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure virtual networks are similar to LANs on your on-premises network. The idea behind an Azure virtual network is that you create a network, based on a single private IP address space, on which you can place all your Azure virtual machines. The private IP address spaces available are in the Class A (10.0.0.0/8), Class B (172.16.0.0/12), and Class C (192.168.0.0/16) ranges."
                },
                new ExplanationEntity()
                {
                    Text = "Best practice: Create network access controls between subnets. Routing between subnets happens automatically, and you don’t need to manually configure routing tables. By default, there are no network access controls between the subnets that you create on an Azure virtual network."
                },
                new ExplanationEntity()
                {
                    Text = "Detail: Use a network security group to protect against unsolicited traffic into Azure subnets. Network security groups are simple, stateful packet inspection devices that use the 5-tuple approach (source IP, source port, destination IP, destination port, and layer 4 protocol) to create allow/deny rules for network traffic. You allow or deny traffic to and from a single IP address, to and from multiple IP addresses, or to and from entire subnets."
                },
                new ExplanationEntity()
                {
                    Text = "When you use network security groups for network access control between subnets, you can put resources that belong to the same security zone or role in their own subnets."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Plan virtual networks",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-vnet-plan-design-arm",
                },
                new ReferenceEntity()
                {
                    Text = "Azure best practices for network security",
                    Url = "https://docs.microsoft.com/en-us/azure/security/fundamentals/network-best-practices",
                },
            },
        };
    }
}