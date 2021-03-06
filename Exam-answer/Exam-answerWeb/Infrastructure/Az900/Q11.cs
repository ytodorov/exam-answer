using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q11Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 11,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company has several business units.",
                },
                new ContentEntity()
                {
                    Text = "Each business unit requires 20 different Azure resources for daily operation. All the business units require the same type of Azure resources.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a solution to automate the creation of the Azure resources.",
                },
                new ContentEntity()
                {
                    Text = "What should you include in the recommendations?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Resource Manager templates.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Virtual machine scale sets.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The Azure API Management service.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Management groups.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Resource Manager Template defines the resources you need to deploy for your solution. First of all, you must know that an Azure Resource Manager Template is a just a simple JSON file. JSON is an open-standard file format derived from JavaScript. Note that a JSON file is a collection of name/value pairs."
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure Quickstart Templates",
                    Url = "https://azure.microsoft.com/en-us/resources/templates/"
                }
            },
        };
    }
}