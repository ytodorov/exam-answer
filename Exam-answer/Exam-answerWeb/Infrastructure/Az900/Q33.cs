
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q32Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 41,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which Azure service should you use to store certificates?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Security Center.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure Storage account.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Key Vault.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Information Protection.", 
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
                    Url = "https://docs.microsoft.com/en-us/azure/key-vault/key-vault-overview",
                },
            },           
        };
    }
}
