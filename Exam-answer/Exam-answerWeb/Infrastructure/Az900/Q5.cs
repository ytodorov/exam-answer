using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q5Instance = new QuestionEntity()
        {
            Order = 5,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Note: This question is part of a series of questions that present the same scenario. Each question in the series contains a unique solution that might meet the stated goals. Some question sets might have more than one correct solution, while others might not have a correct solution.",
                },
                new ContentEntity()
                {
                    Text = "After you answer a question in this section, you will NOT be able to return to it. As a result, these questions will not appear in the review screen."
                },
                new ContentEntity()
                {
                    Text = "An Azure administrator plans to run a PowerShell script that creates Azure resources."
                },
                new ContentEntity()
                {
                    Text = "You need to recommend which computer configuration to use to run the script."
                },
                new ContentEntity()
                {
                    Text = "Solution: Run the script from a computer that runs macOS and has PowerShell Core 6.0 installed."
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?"
                }
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
                    Text = "No."
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