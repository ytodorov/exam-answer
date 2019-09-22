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
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "You deploy an Azure resource. The resource becomes unavailable for an extended period due to a service outage. Microsoft will *** AUTOMATICALLY REFUND YOUR BANK ACCOUNT***.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the UPPER-CASED text surrounded by ***. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
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
                new ExplanationEntity()
                {
                    Text = "If we do not achieve and maintain the Service Levels for each Service as described in this SLA, then you may be eligible for a credit towards a portion of your monthly service fees. We will not modify the terms of your SLA during the initial term of your subscription; however, if you renew your subscription, the version of this SLA that is current at the time of renewal will apply throughout your renewal term. We will provide at least 90 days’ notice for adverse material changes to this SLA."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="SLA for App Service",
                    Url = "https://azure.microsoft.com/en-in/support/legal/sla/app-service/v1_4/"
                }
            },
        };
    }
}