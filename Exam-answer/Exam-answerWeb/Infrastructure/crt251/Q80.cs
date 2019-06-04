using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q80
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 80,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which two solutions should a consultant recommend if a sales process requires opportunities to have associated product line items before moving the opportunity to the negotiation stage?",
                },
                new ContentEntity()
                {
                    Text = "Choose 2 answers.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Ensure that all sales representatives have access to at least one PriceBook when creating product lines.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Configure a validation rule that tests the Has Line Item and Stage fields for the correct condition.",                    
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Define a workflow rule that automatically defaults to a PriceBook and product line item when selecting the negotiation stage.",                    
                },
                new AnswerEntity()
                {
                    Text = "Configure the opportunity record types to enforce product line item entry before selecting the negotiation stage.",
                },
            }
        };
    }
}