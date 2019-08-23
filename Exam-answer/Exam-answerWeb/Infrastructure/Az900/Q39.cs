
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
                    Text = "Note: This question is part of a series of questions that present the same scenario. Each question in the series contains a unique solution that might.",
                },
                new ContentEntity()
                {
                    Text = "Meet the stated goals. Some question sets might have more than one correct solution, while others might not have a correct solution.",
                },
                new ContentEntity()
                {
                    Text = "After you answer a question in this section, you will NOT be able to return to it. As a result, these questions will not appear in the review screen.",
                },
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
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://azure.microsoft.com/en-gb/support/plans/",
                },
            },           
        };
    }
}
