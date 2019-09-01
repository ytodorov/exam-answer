
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q31Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 40,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your network contains an Active Directory forest. The forest contains 5,000 user accounts.",
                },
                new ContentEntity()
                {
                    Text = "Your company plans to migrate all network resources to Azure and to decommission the on-premises data center.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a solution to minimize the impact on users after the planned migration.",
                },
                new ContentEntity()
                {
                    Text = "What should you recommend?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Implement Azure Multi-Factor Authentication (MFA).", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Sync all the Active Directory user accounts to Azure Active Directory (Azure AD).", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Instruct all users to change their password.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create a guest user account in Azure Active Directory (Azure AD) for each user.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Active Directory (Azure AD) is Microsoft’s cloud-based identity and access management service, which helps your employees sign in and access resources in:"
                },
                new ExplanationEntity()
                {
                    Text = "External resources, such as Microsoft Office 365, the Azure portal, and thousands of other SaaS applications."
                },
                new ExplanationEntity()
                {
                    Text = "Internal resources, such as apps on your corporate network and intranet, along with any cloud apps developed by your own organization."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="How to Sync On-premise AD with Windows Azure AD using Azure AD Connect tool ",
                    Url = "https://www.ecanarys.com/Blogs/ArticleID/234/How-to-Sync-On-premise-AD-with-Windows-Azure-AD-using-Azure-AD-Connect-tool"
                },
                new ReferenceEntity()
                {
                    Text ="Step-By-Step: Syncing An On Premise AD with Azure Active Directory",
                    Url = "https://blogs.technet.microsoft.com/canitpro/2014/05/13/step-by-step-syncing-an-on-premise-ad-with-azure-active-directory/"
                }
            },                
        };
    }
}
