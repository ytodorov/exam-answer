
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q9Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 13,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by *** text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "*** AZURE POLICIES PROVIDE *** a common platform for deploying objects to a cloud infrastructure and for implementing consistency across the Azure environment.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
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
                    Text = "Resource groups provide.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Resource Manager provides.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Management groups provide.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Resource Manager is the deployment and management service for Azure. It provides a consistent management layer that enables you to create, update, and delete resources in your Azure subscription. You can use its access control, auditing, and tagging features to secure and organize your resources after deployment."
                },
                new ExplanationEntity()
                {
                    Text = "When you take actions through the portal, PowerShell, Azure CLI, REST APIs, or client SDKs, the Azure Resource Manager API handles your request. Because all requests are handled through the same API, you see consistent results and capabilities in all the different tools. All capabilities that are available in the portal are also available through PowerShell, Azure CLI, REST APIs, and client SDKs."
                },               
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure Resource Manager overview",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-overview"
                },
                new ReferenceEntity()
                {
                    Text = "Azure Resource Manager",
                    Url = "https://azure.microsoft.com/en-us/features/resource-manager/"
                }
            },           
        };
    }
}
