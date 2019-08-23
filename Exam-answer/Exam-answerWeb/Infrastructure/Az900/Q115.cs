
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q114Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 250,
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
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/connect/active-directory-aadconnectsync-troubleshoot-password-hash-synchronization#no-passwords-aresynchronized-",
                },
                new ReferenceEntity()
                {
                    Url = "troubleshoot-by-using-the-troubleshooting-task",
                },
            },           
        };
    }
}
