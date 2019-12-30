using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q100Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 100,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You manage a virtual network named VNet1 that is hosted in the West US Azure region.",
                },
                new ContentEntity()
                {
                    Text = "VNet1 hosts two virtual machines named VM1 and VM2 that run Windows Server.",
                },
                new ContentEntity()
                {
                    Text = "You need to inspect all the network traffic from VM1 to VM2 for a period of three hours.",
                },
                new ContentEntity()
                {
                    Text = "Solution: From Azure Network Watcher, you create a packet capture.",
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "No.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Use the Connection Monitor feature of Azure Network Watcher."
                },
                new ExplanationEntity()
                {
                    Text = "Network Watcher packet capture allows you to create capture sessions to track traffic to and from a virtual machine. Filters are provided for the capture session to ensure you capture only the traffic you want. Packet capture helps to diagnose network anomalies, both reactively, and proactively. Other uses include gathering network statistics, gaining information on network intrusions, to debug client-server communication, and much more. Being able to remotely trigger packet captures, eases the burden of running a packet capture manually on a desired virtual machine, which saves valuable time."
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Tutorial: Monitor network communication between two virtual machines using the Azure portal",
                    Url = "https://docs.microsoft.com/en-us/azure/network-watcher/connection-monitor",
                },
            },
        };
    }
}