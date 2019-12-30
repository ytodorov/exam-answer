using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q26Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 26,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to automate the deployment of servers to Azure.",
                },
                new ContentEntity()
                {
                    Text = "Your manager is concerned that you may expose administrative credentials during the deployment.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend an Azure solution that encrypts the administrative credentials during the deployment.",
                },
                new ContentEntity()
                {
                    Text = "What should you include in the recommendation?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Key Vault.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Information Protection.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Security Center.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Multi-Factor Authentication (MFA).",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Key Vault helps solve the following problems:"
                },
                new ExplanationEntity()
                {
                    Text = "Secrets Management - Azure Key Vault can be used to Securely store and tightly control access to tokens, passwords, certificates, API keys, and other secrets."
                },
                new ExplanationEntity()
                {
                    Text = "Key Management - Azure Key Vault can also be used as a Key Management solution. Azure Key Vault makes it easy to create and control the encryption keys used to encrypt your data."
                },
                new ExplanationEntity()
                {
                    Text = "Certificate Management - Azure Key Vault is also a service that lets you easily provision, manage, and deploy public and private Secure Sockets Layer/Transport Layer Security (SSL/TLS) certificates for use with Azure and your internal connected resources."
                },
                new ExplanationEntity()
                {
                    Text = "Store secrets backed by Hardware Security Modules - The secrets and keys can be protected either by software or FIPS 140-2 Level 2 validates HSMs"
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Key Vault",
                    Url = "https://azure.microsoft.com/en-in/services/key-vault/"
                },
                new ReferenceEntity()
                {
                    Text = "What is Azure Key Vault?",
                    Url = "https://docs.microsoft.com/en-in/azure/key-vault/key-vault-overview"
                },
            },
        };
    }
}