using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        /// <summary>
        /// 17
        /// </summary>
        public static QuestionEntity Q30Instance = new QuestionEntity()
        {
            Order = 30,
            Section = "",
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