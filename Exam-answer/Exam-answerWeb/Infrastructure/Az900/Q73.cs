using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q72Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 194,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Subscription1. Subscription1 contains a resource group named RG1. RG1 contains resources that were deployed by using templates.",
                },
                new ContentEntity()
                {
                    Text = "You need to view the date and time when the resources were created in RG1.",
                },
                new ContentEntity()
                {
                    Text = "Solution: From the Subscriptions blade, you select the subscription, and then click Programmatic deployment.",
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
                    Text = "The Azure Activity Log provides insight into subscription-level events that have occurred in Azure. This includes a range of data, from Azure Resource Manager operational data to updates on Service Health events. The Activity Log was previously known as Audit Logs or Operational Logs, since the Administrative category reports control-plane events for your subscriptions."
                },
                new ExplanationEntity()
                {
                    Text = "Use the Activity Log, to determine the what, who, and when for any write operations (PUT, POST, DELETE) taken on the resources in your subscription. You can also understand the status of the operation and other relevant properties."
                },
                new ExplanationEntity()
                {
                    Text = "The Activity Log does not include read (GET) operations or operations for resources that use the Classic/RDFE model."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Overview of Azure Activity log",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-monitor/platform/activity-logs-overview"
                },
            },
        };
    }
}