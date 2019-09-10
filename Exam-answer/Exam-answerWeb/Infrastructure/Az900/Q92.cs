
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q91Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 224,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You are troubleshooting a performance issue for an Azure Application Gateway.",
                },
                new ContentEntity()
                {
                    Text = "You need to compare the total requests to the failed requests during the past six hours.",
                },
                new ContentEntity()
                {
                    Text = "What should you use?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "NSG flow logs in Azure Network Watcher.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Metrics in Application Gateway.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Connection monitor in Azure Network Watcher.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Diagnostics logs in Application Gateway.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Application Gateway is a web traffic load balancer that enables you to manage traffic to your web applications. Traditional load balancers operate at the transport layer (OSI layer 4 - TCP and UDP) and route traffic based on source IP address and port, to a destination IP address and port."
                },
                new ExplanationEntity()
                {
                    Text = "With Application Gateway, you can make routing decisions based on additional attributes of an HTTP request, such as URI path or host headers. For example, you can route traffic based on the incoming URL. So if /images is in the incoming URL, you can route traffic to a specific set of servers (known as a pool) configured for images. If /video is in the URL, that traffic is routed to another pool that's optimized for videos."
                },
                new ExplanationEntity()
                {
                    Text = "This type of routing is known as application layer (OSI layer 7) load balancing. Azure Application Gateway can do URL-based routing and more."
                },
                new ExplanationEntity()
                {
                    Text = "By using Azure Application Gateway, you can monitor resources in the following ways:"
                },
                new ExplanationEntity()
                {
                    Text = "Back-end health: Application Gateway provides the capability to monitor the health of the servers in the back-end pools through the Azure portal and through PowerShell. You can also find the health of the back-end pools through the performance diagnostic logs.",
                },
                new ExplanationEntity()
                {
                    Text = "Logs: Logs allow for performance, access, and other data to be saved or consumed from a resource for monitoring purposes.",
                },
                new ExplanationEntity()
                {
                    Text = "Metrics: Application Gateway has several metrics which help you verify that your system is performing as expected.",
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Back-end health and diagnostic logs for Application Gateway",
                    Url = "https://docs.microsoft.com/en-us/azure/application-gateway/application-gateway-diagnostics#metrics",
                },
            },           
        };
    }
}
