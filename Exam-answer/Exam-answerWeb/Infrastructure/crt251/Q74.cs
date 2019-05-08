using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q74
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 74,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) plans to integrate with Salesforce and track product shipments from each customer.",
                },
                new ContentEntity()
                {
                    Text = "The tracking information is currently available in a back-end system.",
                },
                new ContentEntity()
                {
                    Text = "Which set of objects are important for this integration?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Opportunity, opportunity product, custom object-shipment status.",
                },
                new AnswerEntity()
                {
                    Text = "Opportunity, opportunity product, campaign, custom object-shipment status.",                    
                },
                new AnswerEntity()
                {
                    Text = "Lead, opportunity, product, custom object-shipment status.",                    
                },
                new AnswerEntity()
                {
                    Text = "Lead, account, opportunity product, custom object-shipment status.",
                },
            }
        };
    }
}