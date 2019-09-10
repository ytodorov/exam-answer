
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q78Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 204,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription that contains the resources in the following table.",
                },
                new ContentEntity()
                {
                    Text = "Name: RG1, Type: Resource group",
                },
                new ContentEntity()
                {
                    Text = "Name: Store1, Type: Azure Storage Account",
                },
                new ContentEntity()
                {
                    Text = "Name: Sync1, Type: Azure File Sync",
                },
                new ContentEntity()
                {
                    Text = "Store1 contains a file share named Data. Data contains 5,000 files.",
                },
                new ContentEntity()
                {
                    Text = "You need to synchronize the files in Data to an on-premises server named Server1.",
                },
                new ContentEntity()
                {
                    Text = "Which three actions should you perform? Each correct answer presents part of the solution.",
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
                    Text = "Download an automation script.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Register Server1.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a sync group.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a container instance.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Install the Azure File Sync agent on Server1.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Use Azure File Sync to centralize your organization's file shares in Azure Files, while keeping the flexibility, performance, and compatibility of an on-premises file server. Azure File Sync transforms Windows Server into a quick cache of your Azure file share. You can use any protocol that's available on Windows Server to access your data locally, including SMB, NFS, and FTPS. You can have as many caches as you need across the world."
                },
                new ExplanationEntity()
                {
                    Text = "Step 1: Install the Azure File Sync agent on Server1. The Azure File Sync agent is a downloadable package that enables Windows Server to be synced with an Azure file share."
                },
                new ExplanationEntity()
                {
                    Text = "Step 2: Register Server1. Register Windows Server with Storage Sync Service. Registering your Windows Server with a Storage Sync Service establishes a trust relationship between your server (or cluster) and the Storage Sync Service."
                },
                new ExplanationEntity()
                {
                    Text = "Step 3: Create a sync group and a cloud endpoint. A sync group defines the sync topology for a set of files. Endpoints within a sync group are kept in sync with each other. A sync group must contain one cloud , which represents an Azure file share and one or more server endpoints. A server endpoint represents a path on registered server."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Deploy Azure File Sync",
                    Url = "https://docs.microsoft.com/en-us/azure/storage/files/storage-sync-files-deployment-guide",
                },
            },           
        };
    }
}
