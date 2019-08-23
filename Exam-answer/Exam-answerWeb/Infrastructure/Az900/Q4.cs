
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q3Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 5,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company hosts an accounting named App1 that is used by all the customers of the company.",
                },
                new ContentEntity()
                {
                    Text = "App1 has low usage during the first three weeks of each month and very high usage during the last week of each month.",
                },
                new ContentEntity()
                {
                    Text = "Which benefit of Azure Cloud Services supports cost management for this type of usage pattern?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "High availability.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "High latency.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Elasticity.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Load balancing.", 
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
