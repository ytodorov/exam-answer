
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q72Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 194,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Note: This question is part of a series of questions that present the same scenario. Each question in the series contains a unique solution that might.",
                },
                new ContentEntity()
                {
                    Text = "Meet the stated goals. Some question sets might have more than one correct solution, while others might not have a correct solution.",
                },
                new ContentEntity()
                {
                    Text = "After you answer a question in this section, you will NOT be able to return to it. As a result, these questions will not appear in the review screen.",
                },
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Subscription1. Subscription1 contains a resource group named RG1. RG1 contains resources that were deployed by using.",
                },
                new ContentEntity()
                {
                    Text = "Templates.",
                },
                new ContentEntity()
                {
                    Text = "You need to view the date and time when the resources were created in RG1.",
                },
                new ContentEntity()
                {
                    Text = "Solution: From the Subscriptions blade, you select the subscription, and then click Programmatic deployment.",
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "No.", 
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
