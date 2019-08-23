
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q85Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 215,
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
                    Text = "The Warning state indicates one or more issues in VM’s configuration that might lead to backup failures and provides recommended steps to ensure successful"
                },
                new ExplanationEntity()
                {
                    Text = "backups. Not having the latest VM Agent installed, for example, can cause backups to fail intermittently and falls in this class of issues."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://azure.microsoft.com/en-us/blog/azure-vm-backup-pre-checks/",
                },
            },           
        };
    }
}
