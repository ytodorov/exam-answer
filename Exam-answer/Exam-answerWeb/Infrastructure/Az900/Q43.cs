
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q42Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 53,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You attempt to create several managed Microsoft SQL Server instances in an Azure environment and receive a message that you must increase your Azure.",
                },
                new ContentEntity()
                {
                    Text = "Subscription limits.",
                },
                new ContentEntity()
                {
                    Text = "What should you do to increase the limits?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a service health alert.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Upgrade your support plan.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Modify an Azure policy.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create a new support request.", 
                    IsCorrect = true
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
