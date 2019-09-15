using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q50Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 85,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to deploy several web servers and several database servers to Azure.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend an Azure solution to limit the types of connections from the web servers to the database servers.",
                },
                new ContentEntity()
                {
                    Text = "What should you include in the recommendation?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Network security groups (NSGs).",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Service Bus.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A local network gateway.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A route filter.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You can filter network traffic to and from Azure resources in an Azure virtual network with a network security group. A network security group contains security rules that allow or deny inbound network traffic to, or outbound network traffic from, several types of Azure resources. To learn about which Azure resources can be deployed into a virtual network and have network security groups associated to them, see Virtual network integration for Azure services. For each rule, you can specify source and destination, port, and protocol."
                },
                new ExplanationEntity()
                {
                    Text = "Network security group security rules are evaluated by priority using the 5-tuple information (source, source port, destination, destination port, and protocol) to allow or deny the traffic. A flow record is created for existing connections. Communication is allowed or denied based on the connection state of the flow record. The flow record allows a network security group to be stateful. If you specify an outbound security rule to any address over port 80, for example, it's not necessary to specify an inbound security rule for the response to the outbound traffic. You only need to specify an inbound security rule if communication is initiated externally. The opposite is also true. If inbound traffic is allowed over a port, it's not necessary to specify an outbound security rule to respond to traffic over the port. Existing connections may not be interrupted when you remove a security rule that enabled the flow. Traffic flows are interrupted when connections are stopped and no traffic is flowing in either direction, for at least a few minutes."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Security groups",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/security-overview"
                },
            },
        };
    }
}