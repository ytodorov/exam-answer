using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q58Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 58,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure Active Directory (Azure AD) tenant.",
                },
                new ContentEntity()
                {
                    Text = "All administrators must enter a verification code to access the Azure portal.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that the administrators can access the Azure portal only from your on-premises network.",
                },
                new ContentEntity()
                {
                    Text = "What should you configure?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "An Azure AD Identity Protection user risk policy.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The multi-factor authentication service settings.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "The default for all the roles in Azure AD Privileged Identity Management.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure AD Identity Protection sign-in risk policy.",
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
                    Text = "Something you know (typically a password)."
                },
                new ExplanationEntity()
                {
                    Text = "Something you have (a trusted device that is not easily duplicated, like a phone)."
                },
                new ExplanationEntity()
                {
                    Text = "Something you are (biometrics)."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="How it works: Azure Multi-Factor Authentication",
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/authentication/concept-mfa-howitworks"
                },
                new ReferenceEntity()
                {
                    Text = "Planning a cloud-based Azure Multi-Factor Authentication deployment",
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/authentication/howto-mfa-getstarted"
                }
            },
        };
    }
}