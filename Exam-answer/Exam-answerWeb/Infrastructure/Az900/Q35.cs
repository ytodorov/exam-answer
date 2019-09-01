
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q34Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 43,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What should you use to evaluate whether your company’s Azure environment meets regulatory requirements?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The Knowledge Center website.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The Advisor blade from the Azure portal.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Compliance Manager from the Security Trust Portal.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The Security Center blade from the Azure portal.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Security Center helps you prevent, detect, and respond to threats with increased visibility into and control over the security of your Azure resources. It provides integrated security monitoring and policy management across your subscriptions, helps detect threats that might otherwise go unnoticed, and works with a broad ecosystem of security solutions."
                },
                new ExplanationEntity()
                {
                    Text = "Azure Security Center is enabled with your Microsoft Azure subscription and accessed from the Azure portal. (Sign in to the portal, select Browse, and scroll to Security Center)."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure Security Center frequently asked questions (FAQ)",
                    Url = "https://docs.microsoft.com/en-us/azure/security-center/security-center-faq"
                },
                new ReferenceEntity()
                {
                    Text= "Regulatory compliance dashboard in Azure Security Center now available",
                    Url = "https://azure.microsoft.com/en-us/blog/regulatory-compliance-dashboard-in-azure-security-center-now-available/",
                },
            },           
        };
    }
}
