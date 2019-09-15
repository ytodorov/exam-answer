using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q17Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 23,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have a virtual machine named VM1 that runs Windows Server 2016. VM1 is in the East US Azure region.",
                },
                new ContentEntity()
                {
                    Text = "Which Azure service should you use from the Azure portal to view service failure notifications that can affect the availability of VM1?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Service Fabric.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Monitor.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure virtual machines.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Advisor.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Monitor maximizes the availability and performance of your applications by delivering a comprehensive solution for collecting, analyzing, and acting on telemetry from your cloud and on-premises environments. It helps you understand how your applications are performing and proactively identifies issues affecting them and the resources they depend on."
                },
                new ExplanationEntity()
                {
                    Text = "All data collected by Azure Monitor fits into one of two fundamental types, metrics and logs. Metrics are numerical values that describe some aspect of a system at a particular point in time. They are lightweight and capable of supporting near real-time scenarios. Logs contain different kinds of data organized into records with different sets of properties for each type. Telemetry such as events and traces are stored as logs in addition to performance data so that it can all be combined for analysis."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure Monitor overview",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-monitor/overview"
                },
                new ReferenceEntity()
                {
                    Text = "Azure Monitor Documentation",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-monitor/"
                },
            },
        };
    }
}