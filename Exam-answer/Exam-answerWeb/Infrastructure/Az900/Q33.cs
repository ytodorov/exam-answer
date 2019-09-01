
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q32Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 41,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which Azure service should you use to store certificates?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Security Center.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure Storage account.", 
                    IsCorrect = false
                },
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
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Key Vault enables Microsoft Azure applications and users to store and use several types of secret/key data:"
                },
                new ExplanationEntity()
                {
                    Text = "Cryptographic keys: Supports multiple key types and algorithms, and enables the use of Hardware Security Modules (HSM) for high value keys."
                },
                new ExplanationEntity()
                {
                    Text = "Secrets: Provides secure storage of secrets, such as passwords and database connection strings."
                },
                new ExplanationEntity()
                {
                    Text = "Certificates: Supports certificates, which are built on top of keys and secrets and add an automated renewal feature."
                },
                new ExplanationEntity()
                {
                    Text = "Azure Storage: Can manage keys of an Azure Storage account for you. Internally, Key Vault can list (sync) keys with an Azure Storage Account, and regenerate (rotate) the keys periodically."
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "About keys, secrets, and certificates",
                    Url = "https://docs.microsoft.com/en-us/azure/key-vault/about-keys-secrets-and-certificates"
                },
                new ReferenceEntity()
                {
                    Text = "What is Azure Key Vault?",
                    Url = "https://docs.microsoft.com/en-us/azure/key-vault/key-vault-overview",
                },
            },           
        };
    }
}
