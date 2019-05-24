using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q11Instance = new QuestionEntity()
        {
            Order = 11,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You are the owner of your organization's Microsoft Azure subscription. You hire a new administrator to help you manage a virtual network that contains nine Windows Server virtual machines (VMs). The deployment is contained in a resource group named prod-rg.",
                },
                new ContentEntity()
                {
                    Text = "You need to provide the administrator with least-privilege access only to the prod-rg resource group. The administrator should be allowed to manage all aspects of the Azure VMs. Your solution should minimize management effort."
                },
                new ContentEntity()
                {
                    Text = "What should you do?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Assign the Allowed virtual machine SKUs Azure Policy at the resource group scope.",
                },
                new AnswerEntity()
                {
                    Text = "Assign a custom Azure Policy at the management group scope.",
                },
                new AnswerEntity()
                {
                    Text = "Assign the administrator to the Contributor role at the resource group scope.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Assign the administrator to the Virtual Machine Operator role at the virtual machine scope.",
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You should assign the administrator to the Contributor role at the resource group scope. The Contributor role-based access control (RBAC) role provides the new administrator with full read/write privileges at that scope. Inheritance ensures that the permissions cascade to the VMs within the prod-rg resource group and minimizes management overhead."
                },
                new ExplanationEntity()
                {
                    Text = "You should not assign the administrator to the Virtual Machine Operator role at the virtual machine scope. The Virtual Machine Operator role does not grant the administrator full access to all resources contained on the virtual network. Moreover, making multiple RBAC assignments requires much more management effort than making a single role assignment at a parent scope."
                },
                new ExplanationEntity()
                {
                    Text = "You should not assign the Allowed virtual machine SKUs Azure Policy at the resource group scope. Doing so only restricts the administrator from selecting VM instance stock-keeping units (SKUs) that are defined in the Azure Policy. The scenario states only that the administrator should be able to fully manage existing VMs within the prod-rg resource group."
                },
                new ExplanationEntity()
                {
                    Text = "You should not assign a custom Azure Policy at the management group scope. Azure Policy is a governance feature that restricts the types of resources administrators can select in Azure Resource Manager. In other words, Azure Policy is fundamentally different from RBAC, which limits the ability for administrators to take particular actions in the first place."
                }
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "What is role-based access control (RBAC)?",
                     Url = "https://docs.microsoft.com/en-us/azure/role-based-access-control/overview",
                },
                new ReferenceEntity()
                {
                     Text = "Classic subscription administrator roles, Azure RBAC roles, and Azure AD administrator roles",
                     Url = "https://docs.microsoft.com/en-us/azure/role-based-access-control/rbac-and-directory-admin-roles",
                },
                new ReferenceEntity()
                {
                     Text = "What is Azure Policy?",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-policy/azure-policy-introduction",
                },
                new ReferenceEntity()
                {
                     Text = "Create and manage policies to enforce compliance",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-policy/create-manage-policy",
                },
            }
        };
    }
}