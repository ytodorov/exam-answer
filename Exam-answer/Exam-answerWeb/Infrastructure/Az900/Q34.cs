using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q34Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 34,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What can Azure Information Protection encrypt?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Network traffic.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Documents and email messages.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "An Azure Storage account.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure SQL database.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Information Protection (sometimes referred to as AIP) is a cloud-based solution that helps an organization to classify and optionally, protect its documents and emails by applying labels. Labels can be applied automatically by administrators who define rules and conditions, manually by users, or a combination where users are given recommendations."
                },
                new ExplanationEntity()
                {
                    Text = "After your content is classified (and optionally protected), you can then track and control how it is used. You can analyze data flows to gain insight into your business, detect risky behaviors and take corrective measures, track access to documents, prevent data leakage or misuse, and so on."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "What is Azure Information Protection?",
                    Url = "https://docs.microsoft.com/en-us/azure/information-protection/what-is-information-protection"
                },
                new ReferenceEntity()
                {
                    Text = "Compliance and supporting information for Azure Information Protection",
                    Url = "https://docs.microsoft.com/en-us/azure/information-protection/compliance",
                },
                new ReferenceEntity()
                {
                    Text = "Quickstart: Configure a label for users to easily protect emails that contain sensitive information",
                    Url = "https://docs.microsoft.com/en-us/azure/information-protection/quickstart-label-dnf-protectedemail",
                },
            },
        };
    }
}