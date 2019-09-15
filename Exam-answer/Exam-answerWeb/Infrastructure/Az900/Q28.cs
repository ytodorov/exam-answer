using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q27Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 36,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which two types of customers are eligible to use Azure Government to develop a cloud solution? Each correct answer presents a complete solution.",
                },
                new ContentEntity()
                {
                    Text = "NOTE: Each correct selection is worth one point.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A Canadian government contractor.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A European government contractor.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A United States government entity.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A United States government contractor.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A European government entity.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Microsoft Azure Government delivers a cloud platform built upon the foundational principles of security, privacy and control, compliance, and transparency. Public Sector entities receive a physically isolated instance of Microsoft Azure that employs world-class security and compliance services critical to U.S. government for all systems and applications built on its architecture."
                },
                new ExplanationEntity()
                {
                    Text = "US government agencies or their partners interested in cloud services that meet government security and compliance requirements, can be confident that Microsoft Azure Government provides world-class security, protection, and compliance services. Azure Government delivers a dedicated cloud enabling government agencies and their partners to transform mission-critical workloads to the cloud. Azure Government services handle data that is subject to certain government regulations and requirements, such as FedRAMP, NIST 800.171 (DIB), ITAR, IRS 1075, DoD L4, and CJIS. In order to provide you with the highest level of security and compliance, Azure Government uses physically isolated datacenters and networks (located in U.S. only)."
                },
                new ExplanationEntity()
                {
                    Text = "Azure Government customers (US federal, state, and local government or their partners) are subject to validation of eligibility. If there is a question about eligibility for Azure Government, you should consult your account team. "
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure Government Documentation",
                    Url = "https://docs.microsoft.com/en-in/azure/azure-government/",
                },
                new ReferenceEntity()
                {
                    Text = "What is Azure Government?",
                    Url = "https://docs.microsoft.com/en-us/learn/modules/intro-to-azure-government/2-what-is-azure-government",
                },
            },
        };
    }
}