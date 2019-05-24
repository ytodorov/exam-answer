using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q13Instance = new QuestionEntity()
        {
            Order = 13,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You are the cloud operations lead for your company's Microsoft Azure subscription. Your team consists of eight administrators who co-manage all Azure-deployed resources.",
                },
                new ContentEntity()
                {
                    Text = "The corporate governance team mandates that all future Azure resources be deployed only within certain regions."
                },
                new ContentEntity()
                {
                    Text = "You need to meet the compliance requirement."
                },
                new ContentEntity()
                {
                    Text = "Which Azure feature should you use?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Taxonomic tags",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Activity Log Analytics",
                },
                new AnswerEntity()
                {
                    Text = "Role-Based Access Control (RBAC)",                   
                },
                new AnswerEntity()
                {
                    Text = "Azure Policy",
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "To meet the new compliance requirement, you should deploy Azure Policy. Azure Policy is a governance feature that allows you to enforce requirements at two Azure scopes: the management group and the resource group. For example, you can require that all deployments are constrained to particular regions, or that only certain virtual machine (VM) sizes are allowed."
                },
                new ExplanationEntity()
                {
                    Text = "You should not use RBAC. RBAC focuses on user actions at different scopes. For example, a user may be restricted with RBAC from creating VMs in any Azure region. By contrast, Azure Policy customizes the properties a user can choose during resource deployment."
                },
                new ExplanationEntity()
                {
                    Text = "You should not use taxonomic tags. These key-value pairs are useful for organizing Azure resources (for instance, to identify different cost centers). However, tags have no authorization capability on their own."
                },
                new ExplanationEntity()
                {
                    Text = "You should not use Activity Log Analytics. This management solution aggregates Azure activity log data in a Log Analytics workspace. Specifically, the activity log records control plane activities such as resource creation, but does not enforce authorization."
                }
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "What is Azure Policy?",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-policy/azure-policy-introduction",
                },
                new ReferenceEntity()
                {
                     Text = "What is role-based access control (RBAC)?",
                     Url = "https://docs.microsoft.com/en-us/azure/role-based-access-control/overview",
                },
                new ReferenceEntity()
                {
                     Text = "Use tags to organize your Azure resources",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-using-tags",
                },
                new ReferenceEntity()
                {
                     Text = "Collect and analyze Azure activity logs in Log Analytics",
                     Url = "https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-activity",
                },
            }
        };
    }
}