using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q19Instance = new QuestionEntity()
        {
            Order = 19,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to request an architectural review of an Azure environment from Microsoft.",
                },
                new ContentEntity()
                {
                    Text = "The company currently has a Basic support plan."
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a new support plan for the company. The solution must minimize costs."
                },
                new ContentEntity()
                {
                    Text = "Which support plan should you recommend?"
                }
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Premier.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Developer."
                },
                new AnswerEntity()
                {
                    Text = "Professional Direct.",
                },
                new AnswerEntity()
                {
                    Text = "Standard."
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "Compare support plans.",
                     Url = "https://azure.microsoft.com/en-gb/support/plans/",
                },                
            }
        };
    }
}