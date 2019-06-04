using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q69
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 69,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A Northern Trail Outfitters (NTO) customer orders four lanterns.",
                },
                new ContentEntity()
                {
                    Text = "The order is activated in Salesforce, and the products are successfully shipped to the customer. One week later, the customer returns one lantern.",
                },
                 new ContentEntity()
                {
                    Text = "How should NTO record the return in Salesforce?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a new Order Product with quantity set to -1.",
                },
                new AnswerEntity()
                {
                    Text = "Create a reduction Order under the activated Order.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Change the quantity value on the Order Product to 3.",
                },
                new AnswerEntity()
                {
                    Text = "Create a custom field on the Order Product object.",
                },
            }
        };
    }
}