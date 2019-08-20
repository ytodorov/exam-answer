using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        /// <summary>
        /// 4 AZ-900.VCEplus.premium.exam.48q
        /// </summary>
        public static QuestionEntity Q21Instance = new QuestionEntity()
        {
            Order = 21,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an on-premises network that contains several servers.",
                },
                new ContentEntity()
                {
                    Text = "You plan to migrate all the servers to Azure."
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a solution to ensure that some of the servers are available if a single Azure data center goes offline for an extended period."
                },
                new ContentEntity()
                {
                    Text = "What should you include in the recommendation?"
                }
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
                    Text = "Elasticity."
                },
                new AnswerEntity()
                {
                    Text = "Scalability.",
                },
                new AnswerEntity()
                {
                    Text = "Low latency."
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