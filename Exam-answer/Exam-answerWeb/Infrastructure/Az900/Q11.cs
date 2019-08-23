
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q10Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 14,
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
            },

            References = new List<ReferenceEntity>()
            {
            },           
        };
    }
}
