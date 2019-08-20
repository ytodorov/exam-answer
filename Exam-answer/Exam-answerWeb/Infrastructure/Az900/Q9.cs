using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q9Instance = new QuestionEntity()
        {
            Order = 9,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASE text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "AZURE POLICIES PROVIDE a common platform for deploying objects to a cloud infrastructure and for implementing consistency across the Azure environment."
                }
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.",
                },
                new AnswerEntity()
                {
                    Text = "Resource groups provide.",
                },
                new AnswerEntity()
                {
                    Text = "Azure Resource Manager provides.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Management groups provide."
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