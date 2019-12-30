using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q67Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 67,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to request an architectural review of an Azure environment from Microsoft."
                },
                new ContentEntity()
                {
                    Text = "The company currently has a Basic support plan.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a new support plan for the company. The solution must minimize costs.",
                },
                new ContentEntity()
                {
                    Text = "Which support plan should you recommend?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Premier.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Developer.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Professional Direct.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Standard.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Architecture Support for Premier Plan: Customer-specific architectural support such as design reviews, performance tuning, configuration and implementation assistance delivered by Microsoft Azure technical specialists."
                },
                new ExplanationEntity()
                {
                    Text = "Operations Support for Premier Plan: Technical account manager-led service reviews and reporting"
                },
                new ExplanationEntity()
                {
                    Text = "Training for Premier Plan: Azure Engineering-led web seminars, on-demand training"
                },
                new ExplanationEntity()
                {
                    Text = "Proactive Guidance for Premier Plan: Designated Technical Account Manager"
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Compare support plans",
                    Url = "https://azure.microsoft.com/en-gb/support/plans/",
                },
            },
        };
    }
}