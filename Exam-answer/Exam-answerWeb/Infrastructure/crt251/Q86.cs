using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q86
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 86,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) attributes a decline in profit to an excessive number of discounts on opportunities.",
                },
                new ContentEntity()
                {
                    Text = "Which two actions can NTO request to monitor and control opportunity discounting?",
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
                    Text = "Ensure that sales management approves discount requests for each opportunity.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Run a report on opportunities showing list price and discounted price.",            
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a custom roll-up summary field to calculate the average product discount for each customer.",                    
                },
                new AnswerEntity()
                {
                    Text = "Limit the number of discounted products that can be added to an opportunity.",
                },
            }
        };
    }
}