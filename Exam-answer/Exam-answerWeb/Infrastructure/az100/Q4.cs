using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q4Instance = new QuestionEntity()
        {
            Order = 4,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You create a Windows Server virtual machine (VM) in an Azure resource group named iaas-rg. You plan to generalize the operating system and capture a system for use in future deployments.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that other administrators make no changes to the virtual machine configuration until you complete the image capture process. You need to enact your solution as quickly as possible."
                },
                new ContentEntity()
                {
                    Text = "Solution: From the Azure Active Directory Roles and administrators blade, you modify the Global administrator role properties."
                },
                new ContentEntity()
                {
                    Text = "What should you do?"
                }
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Set a Read only lock at the resource group level.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Set a Delete lock at the VM level.",
                },
                new AnswerEntity()
                {
                    Text = "Edit the RBAC permissions at the resource group level.",
                },
                new AnswerEntity()
                {
                    Text = "Edit the RBAC permissions at the VM level.",
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Because time is of the essence, you should set a Read only lock at the resource group level. Resource locks in Azure allow you to prevent unwanted changes to Azure resources no matter what the user's privilege level is. For example, even subscription Owners would not be able to resize a VM if the resource has a Read only lock applied to it."
                },
                new ExplanationEntity()
                {
                    Text = "By settings the lock at the VM's parent resource group level, you ensure that other administrators can make no changes to the VM's entire configuration environment, including virtual network interface (vNIC), virtual hard disks (VHDs), and so forth."
                },
                new ExplanationEntity()
                {
                    Text = "We should not set a Delete lock at the VM level for two reasons. First, the Delete resource lock prevents only delete operations, so administrators would be able to undertake other management actions on the VM. Second, a resource-level lock does not affect related VM assets contained in the same resource group."
                },
                new ExplanationEntity()
                {
                    Text = "You should not edit the RBAC permissions at either the resource group or the VM level because the scenario states that you need to enact your solution as quickly as possible. Furthermore, by restricting other administrators' RBAC access, you potentially restrict them from undertaking actions on other VMs to which they should have management access."
                }
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "Lock resources to prevent unexpected changes",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-lock-resources",
                },
                new ReferenceEntity()
                {
                     Text = "What is role-based access control (RBAC)?",
                     Url = "https://docs.microsoft.com/en-us/azure/role-based-access-control/overview",
                },
            }
        };
    }
}