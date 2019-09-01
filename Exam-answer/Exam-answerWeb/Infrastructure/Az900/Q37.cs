
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q36Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 45,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "From *** AZURE MONITOR ***, you can view which user turned off a specific virtual machine during the last 14 days.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the UPPER-CASED text surrounded by ***. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Event Hubs.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Activity Log.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Service Health.", 
                    IsCorrect = false
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
                new ExplanationEntity()
                {
                    Text = "There is a single Activity Log for each Azure subscription. It provides data about the operations on a resource from the outside (the \"control plane\"). Diagnostic Logs are emitted by a resource and provide information about the operation of that resource (the \"data plane\"). You must enable diagnostic settings for each resource."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Overview of Azure Activity log",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-monitor/platform/activity-logs-overview"
                },
                new ReferenceEntity()
                {
                    Text = "View activity logs to monitor actions on resources",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-audit",
                },
            },           
        };
    }
}
