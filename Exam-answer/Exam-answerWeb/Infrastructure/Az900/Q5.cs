
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q4Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 6,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You plan to migrate a web application to Azure. The web application is accessed by external users.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a cloud deployment solution to minimize the amount of administrative effort used to manage the web application.",
                },
                new ContentEntity()
                {
                    Text = "What should you include in the recommendation?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Software as a service (SaaS).", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Platform as a service (PaaS).", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Infrastructure as a service (IaaS).", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Database as a service (DaaS).", 
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
