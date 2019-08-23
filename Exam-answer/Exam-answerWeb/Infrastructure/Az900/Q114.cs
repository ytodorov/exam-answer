
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q113Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 249,
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
            },

            References = new List<ReferenceEntity>()
            {
            },           
        };
    }
}
