
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q28Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 37,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You need to ensure that when Azure Active Directory (Azure AD) users connect to Azure AD from the Internet by using an anonymous IP address, the users are.",
                },
                new ContentEntity()
                {
                    Text = "Prompted automatically to change their password.",
                },
                new ContentEntity()
                {
                    Text = "Which Azure service should you use?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure AD Connect Health.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure AD Privileged Identity Management.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Advanced Threat Protection (ATP).", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure AD Identity Protection.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Active Directory Identity Protection enables organizations to configure automated responses to detected suspicious actions related to user identities."
                },
                new ExplanationEntity()
                {
                    Text = "Microsoft has secured cloud-based identities for more than a decade. With Azure Active Directory Identity Protection, in your environment, you can use the same protection systems Microsoft uses to secure identities."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "What is Azure Active Directory Identity Protection?",
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/identity-protection/overview"
                },
                new ReferenceEntity()
                {
                    Text = "How To: Configure the sign-in risk policy",
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/identity-protection/howto-sign-in-risk-policy",
                },
            },           
        };
    }
}
