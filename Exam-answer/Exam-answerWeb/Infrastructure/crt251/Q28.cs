using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q28
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 28,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "The Universal Containers sales team wants to track product shipments for each of its customers.",
                },
                new ContentEntity()
                {
                    Text = "The shipment tracking information is currently available in a back-end system, which the company plans to integrate with Salesforce."
                },
                new ContentEntity()
                {
                    Text = "Which set of objects are relevant for this integration?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Opportunity, opportunity product, campaign, custom object-shipment status.",
                },
                new AnswerEntity()
                {
                    Text = "Opportunity, opportunity product, custom object-shipment status.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Lead, account, opportunity product, custom object-shipment status.",
                },
                new AnswerEntity()
                {
                    Text = "Lead, opportunity, product, custom object-shipment status.",
                },
            }
        };
    }
}