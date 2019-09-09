
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q71Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 193,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription that contains a resource group named RG1. RG1 contains 100 virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "Your company has three cost centers named Manufacturing, Sales, and Finance.",
                },
                new ContentEntity()
                {
                    Text = "You need to associate each virtual machine to a specific cost center.",
                },
                new ContentEntity()
                {
                    Text = "What should you do?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Configure locks for the virtual machine.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Add an extension to the virtual machines.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Assign tags to the virtual machines.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Modify the inventory settings of the virtual machine.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Billing Tags Policy Initiative:"
                },
                new ExplanationEntity()
                {
                    Text = "Requires specified tag values for cost center and product name. Uses built-in policies to apply and enforce required tags. You specify the required values for the tags."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Prevent unexpected charges with Azure billing and cost management",
                    Url = "https://docs.microsoft.com/en-us/azure/billing/billing-getting-started",
                },
                new ReferenceEntity()
                {
                    Text = "Use tags to organize your Azure resources",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-using-tags",
                },
                new ReferenceEntity()
                {
                    Text = "Sample - Billing tags policy initiative",
                    Url = "https://docs.microsoft.com/en-us/azure/governance/policy/samples/billing-tags-policy-initiative"
                }
            },           
        };
    }
}
