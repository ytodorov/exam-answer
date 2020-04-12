using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q84Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 84,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure virtual machine named VM1 that you use for testing. VM1 is protected by Azure Backup.",
                },
                new ContentEntity()
                {
                    Text = "You delete VM1.",
                },
                new ContentEntity()
                {
                    Text = "You need to remove the backup data stored for VM1.",
                },
                new ContentEntity()
                {
                    Text = "What should you do first?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Delete the Recovery Services vault.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Delete the storage account.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Stop the backup.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Modify the backup policy.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Backup provides backup for virtual machines - created through both the classic deployment model and the Azure Resource Manager deployment model - by using custom-defined backup policies in a Recovery Services vault."
                },
                new ExplanationEntity()
                {
                    Text = "With the release of backup policy management, customers can manage backup policies and model them to meet their changing requirements from a single window. Customers can edit a policy, associate more virtual machines to a policy, and delete unnecessary policies to meet their compliance requirements."
                },
                new ExplanationEntity()
                {
                    Text = "You can't delete a Recovery Services vault if it is registered to a server and holds backup data. If you try to delete a vault, but can't, the vault is still configured to receive backup data."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Backup policy management for Azure VM backup in a Recovery Services vault",
                    Url = "https://azure.microsoft.com/en-in/updates/azure-vm-backup-policy-management/",
                },
            },
        };
    }
}