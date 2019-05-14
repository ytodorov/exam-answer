using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q2Instance = new QuestionEntity()
        {
            Order = 2,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Sub1. Sub1 contains two resource groups named RG1 and RG2.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that Global Administrators can manage all resources contained in RG1 and RG2."
                },
                new ContentEntity()
                {
                    Text = "Solution: From the subscription's Access control (IAM) blade, you click Add role assignment."
                },
                new ContentEntity()
                {
                    Text = "Does this solution meet the goal?"
                }
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes",                    
                },
                new AnswerEntity()
                {
                    Text = "No",
                    IsCorrect = true
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "This solution does not meet the goal. Azure Active Directory (Azure AD) permissions are distinct from Azure resource permissions. In this case, you should enable the Access management for Azure resources property from the Azure AD tenant's Properties blade. This property, when enabled, ensures that Azure AD users assigned to the Global Administrators role maintain full resource access even if their account is stripped from resource-level access control lists (ACLs). The Add role assignment button is used to make an addition to that scope's ACL. For instance, you may need to add a new Azure administrator to the Owner role for a subscription, resource group, or resource."
                }
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "Elevate access for a Global Administrator in Azure Active Directory",
                     Url = "https://docs.microsoft.com/en-us/azure/role-based-access-control/elevate-access-global-admin",
                },
                new ReferenceEntity()
                {
                     Text = "Manage access using RBAC and the Azure portal",
                     Url = "https://docs.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal",
                },
                new ReferenceEntity()
                {
                     Text = "Manage app and resource access using Azure Active Directory groups",
                     Url = "https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-manage-groups",
                },
            }
        };
    }
}