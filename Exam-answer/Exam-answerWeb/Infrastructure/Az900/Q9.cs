using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q9Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 9,
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
                new ExplanationEntity()
                {
                    Text = "Machine Learning Studio is a powerfully simple browser-based, visual drag-and-drop authoring environment where no coding is necessary. Go from idea to deployment in a matter of clicks."
                },
                new ExplanationEntity()
                {
                    Text = "Azure Machine Learning is designed for applied machine learning. Use best-in-class algorithms and a simple drag-and-drop interface-and go from idea to deployment in a matter of clicks. "
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Machine Learning Studio",
                    Url = "https://azure.microsoft.com/en-in/services/machine-learning-studio/"
                }
            },
        };
    }
}