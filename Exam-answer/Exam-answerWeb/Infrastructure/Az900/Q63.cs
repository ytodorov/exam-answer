
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q62Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 174,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company has an Azure Active Directory (Azure AD) tenant named contoso.com that is configured for hybrid coexistence with the on-premises Active Directory Domain.",
                },
                new ContentEntity()
                {
                    Text = "The tenant contains the users shown in the following users.",
                },
                new ContentEntity()
                {
                    Text = "User1: User Type - Member, Source - AzureAD, Sign-in - User1@contoso.com.",
                },
                new ContentEntity()
                {
                    Text = "User2: User Type - Member, Source - Windows Server Active Directory, Sign-in - User2@contoso.com.",
                },
                new ContentEntity()
                {
                    Text = "User3: User Type - Guest, Source - Multiple, Sign-in - User3@outlook.com.",
                },
                new ContentEntity()
                {
                    Text = "User4: User Type - Guest, Source - Multiple, Sign-in - User4@gmail.com.",
                },
                new ContentEntity()
                {
                    Text = "Whenever possible, you need to enable Azure Multi-Factor Authentication (MFA) for the users in contoso.com.",
                },
                new ContentEntity()
                {
                    Text = "Which users should you enable for Azure MFA?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "User1 only.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "User1, User2, and User3 only.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "User1 and User2 only.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "User1, User2, User3, and User4.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "User2 only.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "The security of two-step verification lies in its layered approach. Compromising multiple authentication factors presents a significant challenge for attackers. Even if an attacker manages to learn the user's password, it is useless without also having possession of the additional authentication method. It works by requiring two or more of the following authentication methods:"
                },
                new ExplanationEntity()
                {
                    Text = "Something you know (typically a password)"
                },
                new ExplanationEntity()
                {
                    Text = "Something you have (a trusted device that is not easily duplicated, like a phone)"
                },
                new ExplanationEntity()
                {
                    Text = "Something you are (biometrics)"
                },
                new ExplanationEntity()
                {
                    Text = "Multi-Factor Authentication comes as part of the following offerings:"
                },
                new ExplanationEntity()
                {
                    Text = "Azure Active Directory Premium or Microsoft 365 Business - Full featured use of Azure Multi-Factor Authentication using Conditional Access policies to require multi-factor authentication."
                },
                new ExplanationEntity()
                {
                    Text = "Azure AD Free or standalone Office 365 licenses - Use pre-created Conditional Access baseline protection policies to require multi-factor authentication for your users and administrators."
                },
                new ExplanationEntity()
                {
                    Text = "Azure Active Directory Global Administrators - A subset of Azure Multi-Factor Authentication capabilities are available as a means to protect global administrator accounts."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="How it works: Azure Multi-Factor Authentication",
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/authentication/concept-mfa-howitworks"
                },
            },
        };
    }
}
