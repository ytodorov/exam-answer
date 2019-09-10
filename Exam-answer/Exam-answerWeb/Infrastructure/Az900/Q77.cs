
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q76Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 201,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You plan to use the Azure Import/Export service to copy files to a storage account.",
                },
                new ContentEntity()
                {
                    Text = "Which two files should you create before you prepare the drives for the import job? Each correct answer presents part of the solution.",
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
                    Text = "A driveset CSV file.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A JSON configuration file.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A PowerShell PS1 file.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An XML manifest file.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A dataset CSV file.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "1. Modify the driveset.csv file in the root folder where the tool resides."
                },
                new ExplanationEntity()
                {
                    Text = "2. Modify the dataset.csv file in the root folder where the tool resides. Depending on whether you want to import a file or folder or both, add entries in the dataset.csv file."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Use Azure Import/Export service to import data to Azure Files",
                    Url = "https://docs.microsoft.com/en-us/azure/storage/common/storage-import-export-data-to-files",
                },
            },           
        };
    }
}
