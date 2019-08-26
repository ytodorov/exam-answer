
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q43Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 54,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by *** text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "You deploy an Azure resource. The resource becomes unavailable for an extended period due to a service outage. Microsoft will *** AUTOMATICALLY REFUND YOUR BANK ***.",
                },
                new ContentEntity()
                {
                    Text = "Account.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Automatically migrate the resource to another subscription.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Automatically credit your account.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Send you a coupon code that you can redeem for Azure credits.", 
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
