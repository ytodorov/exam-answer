
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q29Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 38,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "To what should an application connect to retrieve security tokens?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "An Azure Storage account.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Active Directory (Azure AD).", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A certificate store.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure key vault.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "",
                    Url = ""
                },
                new ReferenceEntity()
                {
                    Text = "",
                    Url = ""
                },
            },           
        };
    }
}
