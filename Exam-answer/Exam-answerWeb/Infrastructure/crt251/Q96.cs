using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q96
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 96,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters uses Products in Salesforce and has a private security model.",
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to allow product management employees the ability track the performance of a newly launched products if they do NOT have access to all opportunities?",
                },               
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a criteria-based sharing rule to add the product management team to relevant opportunities.",
                },
                new AnswerEntity()
                {
                    Text = "Create a trigger to add the product management team to the sales team of relevant opportunities.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a trigger to set the product manager as owner for opportunities on the new product.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a new product and add it to the price book with the product manager as an owner.",
                },
            }
        };
    }
}