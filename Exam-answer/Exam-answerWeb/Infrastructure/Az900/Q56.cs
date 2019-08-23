
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q55Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 154,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an on-premises network that contains several servers.",
                },
                new ContentEntity()
                {
                    Text = "You plan to migrate all the servers to Azure.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a solution to ensure that some of the servers are available if a single Azure data center goes offline for an extended period.",
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
                    Text = "Fault tolerance.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Elasticity.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Scalability.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Low latency.", 
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
