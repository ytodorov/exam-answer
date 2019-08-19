using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Az900
{
    public partial class Az900
    {
        public static QuestionEntity Q8Instance = new QuestionEntity()
        {
            Order = 8,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to deploy an Artificial Intelligence (AI) solution in Azure.",
                },
                new ContentEntity()
                {
                    Text = "What should the company use to build, test, and deploy predictive analytics solutions?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Logic Apps.",
                },
                new AnswerEntity()
                {
                    Text = "Azure Machine Learning Studio.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Batch.",
                },
                new AnswerEntity()
                {
                    Text = "Azure Cosmos DB."
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
            },
            References = new List<ReferenceEntity>()
            {
            }
        };
    }
}