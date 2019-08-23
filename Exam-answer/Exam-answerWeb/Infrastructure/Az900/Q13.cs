
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q12Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 16,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Note: This question is part of a series of questions that present the same scenario. Each question in the series contains a unique solution that might.",
                },
                new ContentEntity()
                {
                    Text = "Meet the stated goals. Some question sets might have more than one correct solution, while others might not have a correct solution.",
                },
                new ContentEntity()
                {
                    Text = "After you answer a question in this section, you will NOT be able to return to it. As a result, these questions will not appear in the review screen.",
                },
                new ContentEntity()
                {
                    Text = "You have an Azure environment. You need to create a new Azure virtual machine from an Android laptop.",
                },
                new ContentEntity()
                {
                    Text = "Solution: You use PowerShell in Azure Cloud Shell.",
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "No.", 
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
