
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q15Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 21,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A support engineer plans to perform several Azure management tasks by using the Azure CLI.",
                },
                new ContentEntity()
                {
                    Text = "You install the CLI on a computer.",
                },
                new ContentEntity()
                {
                    Text = "You need to tell the support engineer which tools to use to run the CLI.",
                },
                new ContentEntity()
                {
                    Text = "Which two tools should you instruct the support engineer to use? Each correct answer presents a complete solution.",
                },
                new ContentEntity()
                {
                    Text = "NOTE: Each correct selection is worth one point.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Command Prompt.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Resource Explorer.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Windows PowerShell.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Windows Defender Firewall.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Network and Sharing Center.", 
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
