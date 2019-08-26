
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q7Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 11,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You plan to map a network drive from several computers that run Windows 10 to Azure Storage. You need to create a storage solution in Azure for the planned.",
                },
                new ContentEntity()
                {
                    Text = "Mapped drive.",
                },
                new ContentEntity()
                {
                    Text = "What should you create?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "An Azure SQL database.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A virtual machine data disk.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A Files service in a storage account.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A Blobs service in a storage account.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Files offers fully managed file shares in the cloud that are accessible via the industry standard Server Message Block (SMB) protocol. Azure file shares can be mounted concurrently by cloud or on-premises deployments of Windows, Linux, and macOS. Additionally, Azure file shares can be cached on Windows Servers with Azure File Sync for fast access near where the data is being used."
                },
                new ExplanationEntity()
                {
                    Text = "Azure Files:"
                },
                new ExplanationEntity()
                {
                    Text = "Extend your servers to Azure with Sync for on-premises performance and capability."
                },
                new ExplanationEntity()
                {
                    Text = "Secure data at rest and in-transit using SMB 3.0 and HTTPS."
                },
                new ExplanationEntity()
                {
                    Text = "Simplify cloud file share management using familiar tools."
                },
                new ExplanationEntity()
                {
                    Text = "Create high-performance file shares using the Premium Files storage tier."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "What is Azure Files?",
                    Url = "https://docs.microsoft.com/en-us/azure/storage/files/storage-files-introduction"
                }
            },           
        };
    }
}
