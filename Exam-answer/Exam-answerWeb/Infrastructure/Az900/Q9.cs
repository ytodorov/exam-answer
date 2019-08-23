
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q8Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 12,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to deploy an Artificial Intelligence (AI) solution in Azure.",
                },
                new ContentEntity()
                {
                    Text = "What should the company use to build, test, and deploy predictive analytics solutions?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Logic Apps.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Machine Learning Studio.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Batch.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Cosmos DB.", 
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
