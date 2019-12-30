using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q89Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 89,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You download an Azure Resource Manager template based on an existing virtual machine. The template will be used to deploy 100 virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "You need to modify the template to reference an administrative password. You must prevent the password from being stored in plain text.",
                },
                new ContentEntity()
                {
                    Text = "What should you create to store the password?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "An Azure Key Vault and an access policy.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A Recovery Services vault and a backup policy.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Active Directory (AD) Identity Protection and an Azure policy.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure Storage account and an access policy.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You can use a template that allows you to deploy a simple Windows VM by retrieving the password that is stored in a Key Vault. Therefore, the password is never put in plain text in the template parameter file."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Secure VM password with Key Vault",
                    Url = "https://azure.microsoft.com/en-us/resources/templates/101-vm-secure-password/",
                },
            },
        };
    }
}