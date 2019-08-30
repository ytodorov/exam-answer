
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q111Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 247,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company has an Azure Active Directory (Azure AD) tenant named contoso.com that is configured for hybrid coexistence with the on-premises Active Directory.",
                },
                new ContentEntity()
                {
                    Text = "Domain. The tenant contains the users shown in the following table.",
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

                },
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="",
                    Url = ""
                },
                new ReferenceEntity()
                {
                    Text ="",
                    Url = ""
                }
            },                
        };
    }
}
