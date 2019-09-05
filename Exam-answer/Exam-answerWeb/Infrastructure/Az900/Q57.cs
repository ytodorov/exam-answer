
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q56Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 155,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Active Directory forest named contoso.com.",
                },
                new ContentEntity()
                {
                    Text = "You install and configure Azure AD Connect to use password hash synchronization as the single sign-on (SSO) method. Staging mode is enabled.",
                },
                new ContentEntity()
                {
                    Text = "You review the synchronization results and discover that the Synchronization Service Manager does not display any sync jobs.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that the synchronization completes successfully.",
                },
                new ContentEntity()
                {
                    Text = "What should you do?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Run Azure AD Connect and set the SSO method to Pass-through Authentication.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From Synchronization Service Manager, run a full import.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From Azure PowerShell, run Start-AdSyncSyncCycle –PolicyType Initial.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Run Azure AD Connect and disable staging mode.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Staging mode must be disabled. If the Azure AD Connect server is in staging mode, password hash synchronization is temporarily disabled."
                },
                new ExplanationEntity()
                {
                    Text = "Azure AD Connect is the Microsoft tool designed to meet and accomplish your hybrid identity goals. It provides the following features:"
                },
                new ExplanationEntity()
                {
                    Text = "Password hash synchronization - A sign-in method that synchronizes a hash of a users on-premises AD password with Azure AD."
                },
                new ExplanationEntity()
                {
                    Text = "Pass-through authentication - A sign-in method that allows users to use the same password on-premises and in the cloud, but doesn't require the additional infrastructure of a federated environment."
                },
                new ExplanationEntity()
                {
                    Text = "Federation integration - Federation is an optional part of Azure AD Connect and can be used to configure a hybrid environment using an on-premises AD FS infrastructure. It also provides AD FS management capabilities such as certificate renewal and additional AD FS server deployments."
                },
                new ExplanationEntity()
                {
                    Text = "Synchronization - Responsible for creating users, groups, and other objects. As well as, making sure identity information for your on-premises users and groups is matching the cloud. This synchronization also includes password hashes."
                },
                new ExplanationEntity()
                {
                    Text = "Health Monitoring - Azure AD Connect Health can provide robust monitoring and provide a central location in the Azure portal to view this activity."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Troubleshoot password hash synchronization with Azure AD Connect sync",
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/connect/active-directory-aadconnectsync-troubleshoot-password-hash-synchronization#no-passwords-aresynchronized-",
                },
            },
        };
    }
}
