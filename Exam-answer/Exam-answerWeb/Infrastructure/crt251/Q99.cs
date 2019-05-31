using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q99
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 99,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers is expanding sales internationally and has created new price books to handle the various currencies for the five new countries. When a sales representative selects one of the new price books to add a product to an opportunity, there are no products available.",
                },
                new ContentEntity()
                {
                    Text = "What should be evaluated when troubleshooting this issue?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Confirm that product line items on opportunities are enabled.",
                },
                new AnswerEntity()
                {
                    Text = "Confirm that the products are shared with the sales representative’s role.",                    
                },
                new AnswerEntity()
                {
                    Text = "Confirm that the old price book is disabled for the sales representative.",                    
                },
                new AnswerEntity()
                {
                    Text = "Confirm that the products and currencies are associated with the price book.",
                    IsCorrect = true
                },
            }
        };
    }
}