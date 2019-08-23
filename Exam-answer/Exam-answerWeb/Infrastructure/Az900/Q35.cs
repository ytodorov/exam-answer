
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q34Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 43,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What should you use to evaluate whether your company’s Azure environment meets regulatory requirements?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The Knowledge Center website.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The Advisor blade from the Azure portal.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Compliance Manager from the Security Trust Portal.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The Security Center blade from the Azure portal.", 
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
                    Url = "https://azure.microsoft.com/en-us/blog/regulatory-compliance-dashboard-in-azure-security-center-now-available/",
                },
            },           
        };
    }
}
