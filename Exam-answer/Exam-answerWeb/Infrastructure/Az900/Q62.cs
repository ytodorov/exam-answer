using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q62Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 62,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "*** AZURE POLICIES PROVIDE *** a common platform for deploying objects to a cloud infrastructure and for implementing consistency across the Azure environment.",
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
                    Text = "Azure Resource Manager is the deployment and management service for Azure. It provides a management layer that enables you to create, update, and delete resources in your Azure subscription. You use management features, like access control, locks, and tags, to secure and organize your resources after deployment."
                },
                new ExplanationEntity()
                {
                    Text = "When a user sends a request from any of the Azure tools, APIs, or SDKs, Resource Manager receives the request. It authenticates and authorizes the request. Resource Manager sends the request to the Azure service, which takes the requested action. Because all requests are handled through the same API, you see consistent results and capabilities in all the different tools."
                },
                new ExplanationEntity()
                {
                    Text = "Terminology:"
                },
                new ExplanationEntity()
                {
                    Text = "resource - A manageable item that is available through Azure. Virtual machines, storage accounts, web apps, databases, and virtual networks are examples of resources."
                },
                new ExplanationEntity()
                {
                    Text = "resource group - A container that holds related resources for an Azure solution. The resource group includes those resources that you want to manage as a group. You decide which resources belong in a resource group based on what makes the most sense for your organization. "
                },
                new ExplanationEntity()
                {
                    Text = "resource provider - A service that supplies Azure resources. For example, a common resource provider is Microsoft.Compute, which supplies the virtual machine resource. Microsoft.Storage is another common resource provider."
                },
                new ExplanationEntity()
                {
                    Text = "Resource Manager template - A JavaScript Object Notation (JSON) file that defines one or more resources to deploy to a resource group or subscription. The template can be used to deploy the resources consistently and repeatedly. "
                },
                new ExplanationEntity()
                {
                    Text = "declarative syntax - Syntax that lets you state \"Here is what I intend to create\" without having to write the sequence of programming commands to create it. The Resource Manager template is an example of declarative syntax. In the file, you define the properties for the infrastructure to deploy to Azure. "
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Azure Resource Manager overview",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-overview"
                },
                new ReferenceEntity()
                {
                    Text ="Resource Manager on Azure documentation",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/"
                }
            },
        };
    }
}