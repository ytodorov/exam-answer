using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q16Instance = new QuestionEntity()
        {
            Order = 16,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASE text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "RESOURCE GROUPS provide organizations with the ability to manage the compliance of Azure resources across multiple subscriptions."
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct."
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
                    Text = "Management groups."
                },
                new AnswerEntity()
                {
                    Text = "Azure policies.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure App Service plans."
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