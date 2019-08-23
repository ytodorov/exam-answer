
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
                    Text = "Step 1 (E): Install the Azure File Sync agent on Server1"
                },
                new ExplanationEntity()
                {
                    Text = "The Azure File Sync agent is a downloadable package that enables Windows Server to be synced with an Azure file share"
                },
                new ExplanationEntity()
                {
                    Text = "Step 2 (B): Register Server1."
                },
                new ExplanationEntity()
                {
                    Text = "Register Windows Server with Storage Sync Service"
                },
                new ExplanationEntity()
                {
                    Text = "Registering your Windows Server with a Storage Sync Service establishes a trust relationship between your server (or cluster) and the Storage Sync Service."
                },
                new ExplanationEntity()
                {
                    Text = "Step 3 (C): Create a sync group and a cloud endpoint."
                },
                new ExplanationEntity()
                {
                    Text = "A sync group defines the sync topology for a set of files. Endpoints within a sync group are kept in sync with each other. A sync group must contain one cloud"
                },
                new ExplanationEntity()
                {
                    Text = "endpoint, which represents an Azure file share and one or more server endpoints. A server endpoint represents a path on registered server."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/storage/files/storage-sync-files-deployment-guide",
                },
            },           
        };
    }
}
