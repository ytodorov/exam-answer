using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Az900
{
    public partial class Az900
    {
        public static QuestionEntity Q14Instance = new QuestionEntity()
        {
            Order = 14,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You need to ensure that when Azure Active Directory (Azure AD) users connect to Azure AD from the Internet by using an anonymous IP address, the users are prompted automatically to change their password.",
                },
                new ContentEntity()
                {
                    Text = "Which Azure service should you use?"
                },                
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure AD Connect Health.",
                },
                new AnswerEntity()
                {
                    Text = "Azure AD Privileged Identity Management."
                },
                new AnswerEntity()
                {
                    Text = "Azure Advanced Threat Protection (ATP).",
                },
                new AnswerEntity()
                {
                    Text = "Azure AD Identity Protection.",
                    IsCorrect = true
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
               
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "How To: Configure the sign-in risk policy",
                     Url = "https://docs.microsoft.com/en-us/azure/active-directory/identity-protection/howto-sign-in-risk-policy",
                },
            }
        };
    }
}