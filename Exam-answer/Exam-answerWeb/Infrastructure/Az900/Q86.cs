using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q86Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 86,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You plan to back up an Azure virtual machine named VM1.",
                },
                new ContentEntity()
                {
                    Text = "You discover that the Backup Pre-Check status displays a status of Warning.",
                },
                new ContentEntity()
                {
                    Text = "What is a possible cause of the Warning status?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "VM1 is stopped.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "VM1 does not have the latest version of WaAppAgent.exe installed.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "VM1 has an unmanaged disk.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A Recovery Services vault is unavailable.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "The WARNING state indicates one or more issues in VM’s configuration that might lead to backup failures and provides recommended steps to ensure successful backups. Not having the latest VM Agent installed, for example, can cause backups to fail intermittently and falls in this class of issues."
                },
                new ExplanationEntity()
                {
                    Text = "The PASSED state indicates that your VMs configuration is conducive for successful backups and no corrective action needs to be taken."
                },
                new ExplanationEntity()
                {
                    Text = "The CRITICAL state indicates one or more critical issues in the VM’s configuration that will lead to backup failures and provides required steps to ensure successful backups. A network issue caused due to an update to the NSG rules of a VM, for example, will fail backups as it prevents the VM from communicating with the Azure Backup service and falls in this class of issues."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Introducing Backup Pre-Checks for Backup of Azure VMs",
                    Url = "https://azure.microsoft.com/en-us/blog/azure-vm-backup-pre-checks/",
                },
            },
        };
    }
}