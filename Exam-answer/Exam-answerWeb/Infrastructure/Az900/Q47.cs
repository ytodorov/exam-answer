
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q46Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 77,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by *** text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "When you need to delegate permissions to several Azure virtual machines simultaneously, you must deploy the Azure virtual machines to the same Azure region.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "By using the same Azure Resource Manager template.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "To the same resource group.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "To the same availability zone.", 
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
