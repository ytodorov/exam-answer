
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q22Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 31,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company has an Azure environment that contains resources in several regions.",
                },
                new ContentEntity()
                {
                    Text = "A company policy states that administrators must only be allowed to create additional Azure resources in a region in the country where their office is located.",
                },
                new ContentEntity()
                {
                    Text = "You need to create the Azure resource that must be used to meet the policy requirement.",
                },
                new ContentEntity()
                {
                    Text = "What should you create?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A read-only lock.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure policy.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A management group.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A reservation.", 
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
                    Text = "Overview of the Azure Policy service",
                    Url = "https://docs.microsoft.com/en-us/azure/governance/policy/overview"
                },
                new ReferenceEntity()
                {
                    Text = "Documentation for the Azure Policy service",
                    Url = "https://docs.microsoft.com/en-us/azure/governance/policy/"
                },
            },           
        };
    }
}
