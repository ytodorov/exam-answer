﻿using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q1Instance = new QuestionEntity()
        {
            Order = 1,
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
                    Text = "Solution: From the Azure Active Directory Properties blade, you enable Access management for Azure resources."
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
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "No"
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "This solution does meet the goal. The Access management for Azure resources property, located in the Azure Active Directory (Azure AD) tenant's settings, ensures that Azure AD users assigned to the Global Administrator role maintain full control over all subscription resources in the event that the identity is removed from Azure resource-level access lists. In keeping with least-privilege security, Microsoft recommends that you enable this property only when necessary."
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
                new ReferenceEntity()
                {
                     Text = "Administrator role permissions in Azure Active Directory",
                     Url = "https://docs.microsoft.com/en-us/azure/active-directory/users-groups-roles/directory-assign-admin-roles",
                },
            }
        };
    }
}