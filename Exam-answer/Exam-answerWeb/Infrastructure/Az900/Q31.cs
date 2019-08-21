using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        /// <summary>
        /// 20
        /// </summary>
        public static QuestionEntity Q31Instance = new QuestionEntity()
        {
            Order = 31,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Azure policies provide a common platform for deploying objects to a cloud infrastructure and for implementing consistency across the Azure environment.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the UPPER-CASE text. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct."
                },               
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.",
                },
                new AnswerEntity()
                {
                    Text = "Resource groups provide."
                },
                new AnswerEntity()
                {
                    Text = "Azure Resource Manager provides.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Management groups provide."
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