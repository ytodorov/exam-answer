using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q31Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 31,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "*** RESOURCE GROUPS *** provide organizations with the ability to manage the compliance of Azure resources across multiple subscriptions.",
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
                    Text = "Management groups.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure policies.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure App Service plans.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Policy is a service in Azure that you use to create, assign, and manage policies. These policies enforce different rules and effects over your resources, so those resources stay compliant with your corporate standards and service level agreements. Azure Policy meets this need by evaluating your resources for non-compliance with assigned policies. For example, you can have a policy to allow only a certain SKU size of virtual machines in your environment. Once this policy is implemented, new and existing resources are evaluated for compliance. With the right type of policy, existing resources can be brought into compliance."
                },
                new ExplanationEntity()
                {
                    Text = "There are a few key differences between Azure Policy and role-based access control (RBAC). RBAC focuses on user actions at different scopes. You might be added to the contributor role for a resource group, allowing you to make changes to that resource group. Azure Policy focuses on resource properties during deployment and for already existing resources. Azure Policy controls properties such as the types or locations of resources. Unlike RBAC, Azure Policy is a default allow and explicit deny system."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Overview of the Azure Policy service",
                    Url = "https://docs.microsoft.com/en-us/azure/governance/policy/overview"
                },
                new ReferenceEntity()
                {
                    Text ="Tutorial: Create and manage policies to enforce compliance",
                    Url = "https://docs.microsoft.com/en-us/azure/governance/policy/tutorials/create-and-manage"
                }
            },
        };
    }
}