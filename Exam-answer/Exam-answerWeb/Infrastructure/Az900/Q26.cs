
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q25Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 34,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to automate the deployment of servers to Azure.",
                },
                new ContentEntity()
                {
                    Text = "Your manager is concerned that you may expose administrative credentials during the deployment.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend an Azure solution that encrypts the administrative credentials during the deployment.",
                },
                new ContentEntity()
                {
                    Text = "What should you include in the recommendation?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
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
                new AnswerEntity()
                {
                    Text = "Azure Security Center.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Multi-Factor Authentication (MFA).", 
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
