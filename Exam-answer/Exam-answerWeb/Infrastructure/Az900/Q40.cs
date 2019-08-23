
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q39Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 50,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What is required to use Azure Cost Management?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A Dev/Test subscription.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Software Assurance.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Enterprise Agreement (EA).", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A pay-as-you-go subscription.", 
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
                    Url = "https://docs.microsoft.com/en-gb/azure/cost-management/overview-cost-mgt",
                },
            },           
        };
    }
}
