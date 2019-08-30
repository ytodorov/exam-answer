
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
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
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
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/identity-protection/howto-sign-in-risk-policy",
                },
            },           
        };
    }
}
