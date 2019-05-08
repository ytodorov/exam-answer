using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q50
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 50,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What solution should a consultant recommend to meet this criterion?",
                },
                new ContentEntity()
                {
                    Text = "Universal containers have set up a sales process that requires opportunities to have associated product line items before moving to the negotiation stage.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Define a workflow rule that automatically defaults to a pricebook and negotiation stage.",                    
                },
                new AnswerEntity()
                {
                    Text = "Configure the opportunity record types to enforce product line item.",                    
                },
                new AnswerEntity()
                {
                    Text = "Ensure that all sales representatives have access to at least one pricebook when creating product lines.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Configure a validation rule that tests the product line item and stage fields for the correct condition.",
                    IsCorrect = true
                },
            }
        };
    }
}