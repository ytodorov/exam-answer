using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q47Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 47,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "When you need to delegate permissions to several Azure virtual machines simultaneously, you must deploy the Azure virtual machines *** TO THE SAME AZURE REGION ***.",
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
                    Text = "By using the same Azure Resource Manager template.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "To the same resource group.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "To the same availability zone.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Access management for cloud resources is a critical function for any organization that is using the cloud. Role-based access control (RBAC) helps you manage who has access to Azure resources, what they can do with those resources, and what areas they have access to."
                },
                new ExplanationEntity()
                {
                    Text = "Here are some examples of what you can do with RBAC:"
                },
                new ExplanationEntity()
                {
                    Text = "* Allow one user to manage virtual machines in a subscription and another user to manage virtual networks."
                },
                new ExplanationEntity()
                {
                    Text = "* Allow a DBA group to manage SQL databases in a subscription"
                },
                new ExplanationEntity()
                {
                    Text = "* Allow a user to manage all resources in a resource group, such as virtual machines, websites, and subnets"
                },
                new ExplanationEntity()
                {
                    Text = "* Allow an application to access all resources in a resource group"
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Manage access to Azure resources using RBAC and the Azure portal",
                    Url = "https://docs.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal"
                },
                new ReferenceEntity()
                {
                    Text ="What is role-based access control (RBAC) for Azure resources?",
                    Url = "https://docs.microsoft.com/en-us/azure/role-based-access-control/overview"
                }
            },
        };
    }
}