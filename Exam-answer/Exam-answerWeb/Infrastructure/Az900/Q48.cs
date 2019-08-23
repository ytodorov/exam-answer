
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q47Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 78,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the underlined text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "One of the benefits of Azure SQL Data Warehouse is that high availability is built into the platform.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select “No change is needed”. If the statement is incorrect, select the answer choice that.",
                },
                new ContentEntity()
                {
                    Text = "Makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Automatic scaling.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Data compression.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Versioning.", 
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
