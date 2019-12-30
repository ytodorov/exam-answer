using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q78Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 78,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You create an Azure Storage account named contosostorage.",
                },
                new ContentEntity()
                {
                    Text = "You plan to create a file share named data.",
                },
                new ContentEntity()
                {
                    Text = "Users need to map a drive to the data file share from home computers that run Windows 10.",
                },
                new ContentEntity()
                {
                    Text = "Which outbound port should you open between the home computers and the data file share?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "80.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "443.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "445.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "3389.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Files is Microsoft's easy-to-use cloud file system. Azure file shares can be seamlessly used in Windows and Windows Server."
                },
                new ExplanationEntity()
                {
                    Text = "Prerequisites:"
                },
                new ExplanationEntity()
                {
                    Text = "Storage account name: To mount an Azure file share, you will need the name of the storage account."
                },
                new ExplanationEntity()
                {
                    Text = "Storage account key: To mount an Azure file share, you will need the primary (or secondary) storage key. SAS keys are not currently supported for mounting."
                },
                new ExplanationEntity()
                {
                    Text = "Ensure port 445 is open: The SMB protocol requires TCP port 445 to be open; connections will fail if port 445 is blocked. You can check to see if your firewall is blocking port 445 with the Test-NetConnection cmdlet."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Use an Azure file share with Windows",
                    Url = "https://docs.microsoft.com/en-us/azure/storage/files/storage-how-to-use-files-windows",
                },
            },
        };
    }
}