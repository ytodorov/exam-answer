
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q40Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 51,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "Your Azure trial account expired last week. You are now unable to *** CREATE ADDITIONAL AZURE ACTIVE DIRECTORY (AZURE AD) USER ACCOUNTS ***.",
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
                    Text = "Start an existing Azure virtual machine.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Access your data stored in Azure.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Access the Azure portal.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Your credit is expired:"
                },
                new ExplanationEntity()
                {
                    Text = "When you sign up for an Azure free account, you get a Free Trial subscription, which provides you $200 in Azure credits for 30 days and 12 months of free services. At the end of 30 days, Azure disables your subscription. Your subscription is disabled to protect you from accidentally incurring charges for usage beyond the credit and free services included with your subscription. To continue using Azure services, you must upgrade your subscription. After you upgrade, your subscription still has access to free services for 12 months. You only get charged for usage beyond the free services and quantities."
                },
                new ExplanationEntity()
                {
                    Text = "You reached your spending limit:"
                },
                new ExplanationEntity()
                {
                    Text = "Azure subscriptions with credit such as Free Trial and Visual Studio Enterprise have spending limits on them. This means you can only use services up to the included credit. When your usage reaches the spending limit, Azure disables your subscription for the remainder of that billing period. Your subscription is disabled to protect you from accidentally incurring charges for usage beyond the credit included with your subscription. To remove your spending limit, see Remove the spending limit in Account Center."
                },
              
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Azure free account FAQ",
                    Url = "https://azure.microsoft.com/en-us/free/free-account-faq/"
                },
                new ReferenceEntity()
                {
                    Text ="Reactivate a disabled Azure subscription",
                    Url = "https://docs.microsoft.com/bs-latn-ba/azure/billing/billing-subscription-become-disable"
                }
            },                
        };
    }
}
