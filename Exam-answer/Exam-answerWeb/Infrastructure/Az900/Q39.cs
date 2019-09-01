
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q38Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 47,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to purchase Azure.",
                },
                new ContentEntity()
                {
                    Text = "The company’s support policy states that the Azure environment must provide an option to access support engineers by phone or email.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend which support plan meets the support policy requirement.",
                },
                new ContentEntity()
                {
                    Text = "Solution: Recommend a Basic support plan.",
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "No.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "BASIC: No Technical Support."
                },
                new ExplanationEntity()
                {
                    Text = "DEVELOPER: Business hours access1 to Support Engineers via email"
                },
                new ExplanationEntity()
                {
                    Text = "STANDARD, PROFESSIONAL DIRECT, PREMIER: 24x7 access to Support Engineers via email and phone"
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
