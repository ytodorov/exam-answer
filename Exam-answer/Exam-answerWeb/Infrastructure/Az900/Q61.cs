using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q61Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 61,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
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
                    Text = "Azure Machine Learning Studio gives you an interactive, visual workspace to easily build, test, and iterate on a predictive analysis model."
                },
                new ExplanationEntity()
                {
                    Text = "Microsoft Azure Machine Learning Studio is a collaborative, drag-and-drop tool you can use to build, test, and deploy predictive analytics solutions on your data. Machine Learning Studio publishes models as web services that can easily be consumed by custom apps or BI tools such as Excel."
                },
                new ExplanationEntity()
                {
                    Text = "Machine Learning Studio is where data science, predictive analytics, cloud resources, and your data meet."
                },
                new ExplanationEntity()
                {
                    Text = "To develop a predictive analysis model, you typically use data from one or more sources, transform, and analyze that data through various data manipulation and statistical functions, and generate a set of results. Developing a model like this is an iterative process. As you modify the various functions and their parameters, your results converge until you are satisfied that you have a trained, effective model."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="What is Azure Machine Learning Studio?",
                    Url = "https://docs.microsoft.com/en-us/azure/machine-learning/studio/what-is-ml-studio"
                },
            },
        };
    }
}