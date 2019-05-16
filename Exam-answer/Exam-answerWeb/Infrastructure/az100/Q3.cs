using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q3Instance = new QuestionEntity()
        {
            Order = 3,
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
                    Text = "Solution: From the Azure Active Directory Roles and administrators blade, you modify the Global administrator role properties."
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
                    Text = "This solution does not meet the goal. To ensure that Global Administrators maintain full access to Azure resources, you need to enable the Access management for Azure resources property from the Azure AD tenant's Properties blade."
                },
                new ExplanationEntity()
                {
                    Text = "The only properties of the Global Administrators (or any Azure AD) group that can be modified are the name, description, and membership type field. None of these properties accomplishes the scenario requirement."
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