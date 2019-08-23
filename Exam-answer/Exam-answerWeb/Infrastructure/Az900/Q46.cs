
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q45Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 56,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Note: This question is part of a series of questions that present the same scenario. Each question in the series contains a unique solution that might.",
                },
                new ContentEntity()
                {
                    Text = "Meet the stated goals. Some question sets might have more than one correct solution, while others might not have a correct solution.",
                },
                new ContentEntity()
                {
                    Text = "After you answer a question in this section, you will NOT be able to return to it. As a result, these questions will not appear in the review screen.",
                },
                new ContentEntity()
                {
                    Text = "Your company has an Azure subscription that contains the following unused resources:.",
                },
                new ContentEntity()
                {
                    Text = "20 user accounts in Azure Active Directory (Azure AD).",
                },
                new ContentEntity()
                {
                    Text = "Five groups in Azure AD.",
                },
                new ContentEntity()
                {
                    Text = "10 public IP addresses.",
                },
                new ContentEntity()
                {
                    Text = "10 network interfaces.",
                },
                new ContentEntity()
                {
                    Text = "You need to reduce the Azure costs for the company.",
                },
                new ContentEntity()
                {
                    Text = "Solution: You remove the unused network interfaces.",
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "No.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/advisor/advisor-cost-recommendations#reduce-costs-by-deleting-or-reconfiguring-idle-virtual-network-gateways",
                },
            },           
        };
    }
}
