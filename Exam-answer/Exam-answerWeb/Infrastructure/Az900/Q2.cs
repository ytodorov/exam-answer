using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q2Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 2,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "When planning to migrate a public website to Azure, you must plan to *** PAY MONTHLY USAGE *** costs.",
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
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Deploy a VPN.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Pay to transfer all the website data to Azure.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Reduce the number of connections to the website.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure doesn't directly bill based on the resource cost. Charges for a resource are calculated by using one or more meters. Meters are used to track a resource's usage throughout its lifetime. These meters are then used to calculate the bill."
                },
                new ExplanationEntity()
                {
                    Text = "For example, when you create a single Azure resource, like a virtual machine, it has one or more meter instances created. Meters are used to track the usage of the resource over time. Each meter emits usage records that are used by Azure to calculate the bill."
                },
                new ExplanationEntity()
                {
                    Text = "For example, a single virtual machine (VM) created in Azure may have the following meters created to track its usage:"
                },
                new ExplanationEntity()
                {
                    Text = "Compute Hours, IP Address Hours, Data Transfer In, Data Transfer Out, Standard Managed Disk, Standard Managed Disk Operations, Standard IO-Disk, Standard IO-Block Blob Read, Standard IO-Block Blob Write, Standard IO-Block Blob Delete"
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Understand your Microsoft Azure bill",
                    Url = "https://docs.microsoft.com/en-us/azure/billing/billing-understand-your-bill"
                },
                new ReferenceEntity()
                {
                    Text = "Pricing calculator",
                    Url = "https://azure.microsoft.com/en-in/pricing/calculator/"
                }
            },
        };
    }
}