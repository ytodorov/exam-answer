using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q74Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 74,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You need to move the blueprint files to Azure.",
                },
                new ContentEntity()
                {
                    Text = "What should you do?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Use Azure Storage Explorer to copy the files.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Use the Azure Import/Export service.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Generate a shared access signature (SAS). Map a drive, and then copy the files by using File Explorer.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Generate an access key. Map a drive, and then copy the files by using File Explorer.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Storage Explorer is a free tool from Microsoft that allows you to work with Azure Storage data on Windows, macOS, and Linux. You can use it to upload and download data from Azure blob storage."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Move data to and from Azure Blob Storage using Azure Storage Explorer",
                    Url = "https://docs.microsoft.com/en-us/azure/machine-learning/team-data-science-process/move-data-to-azure-blob-using-azure-storage-explorer",
                },
            },
        };
    }
}