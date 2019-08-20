using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        /// <summary>
        /// 3 AZ-900.VCEplus.premium.exam.48q
        /// </summary>
        public static QuestionEntity Q20Instance = new QuestionEntity()
        {
            Order = 20,
            Section = "Understand cloud concepts",
            Contents = new List<ContentEntity>()
            {
                 new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASE text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "When you are implementing a software as a service (SaaS) solution, you are responsible for CONFIGURING HIGH AVAILABILITY.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the UPPER-CASE text. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct."
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.",
                },
                new AnswerEntity()
                {
                    Text = "Defining scalability rules."
                },
                new AnswerEntity()
                {
                    Text = "Installing the SaaS solution.",
                },
                new AnswerEntity()
                {
                    Text = "Configuring the SaaS solution.",
                    IsCorrect = true
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