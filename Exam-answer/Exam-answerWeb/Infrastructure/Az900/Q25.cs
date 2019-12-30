using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q25Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 25,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to migrate all on-premises data to Azure. You need to identify whether Azure complies with the company’s regional requirements.",
                },
                new ContentEntity()
                {
                    Text = "What should you use?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The Knowledge Center.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Marketplace.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The Azure portal.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The Trust Center.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "The Azure Security Information site on Azure.com gives you the information you need to plan, design, deploy, configure, and manage your cloud solutions securely. With the Microsoft Trust center, you also have the information you need to be confident that the Azure platform on which you run your services is secure."
                },
                new ExplanationEntity()
                {
                    Text = "Compliance: Microsoft helps organizations comply with national, regional, and industry-specific requirements governing the collection and use of individuals’ data."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Microsoft Trust Center",
                    Url = "https://www.microsoft.com/en-us/trust-center/product-overview"
                },
                new ReferenceEntity()
                {
                    Text = "Microsoft Trust Center Home",
                    Url = "https://www.microsoft.com/en-us/trust-center"
                },
            },
        };
    }
}