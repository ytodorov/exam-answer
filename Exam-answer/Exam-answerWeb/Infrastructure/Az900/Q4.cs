
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
                new ExplanationEntity()
                {
                    Text = "Elastic computing is the ability to quickly expand or decrease computer processing, memory, and storage resources to meet changing demands without worrying about capacity planning and engineering for peak usage. Typically controlled by system monitoring tools, elastic computing matches the amount of resources allocated to the amount of resources actually needed without disrupting operations. With cloud elasticity, a company avoids paying for unused capacity or idle resources and doesn’t have to worry about investing in the purchase or maintenance of additional resources and equipment."
                },
                new ExplanationEntity()
                {
                    Text = "While security and limited control are concerns to take into account when considering elastic cloud computing, it has many benefits. Elastic computing is more efficient than your typical IT infrastructure, is typically automated so it doesn’t have to rely on human administrators around the clock, and offers continuous availability of services by avoiding unnecessary slowdowns or service interruptions."
                }
            },

            References = new List<ReferenceEntity>()
            {
            },           
        };
    }
}
