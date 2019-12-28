using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q80Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 241,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "OVERVIEW:",
                },
                new ContentEntity()
                {
                    Text = "Contoso, Ltd. is a manufacturing company that has offices worldwide. Contoso works with partner organizations to bring products to market. Contoso products are manufactured by using blueprint files that the company authors and maintains.",
                },
                new ContentEntity()
                {
                    Text = "EXISTING ENVIRONMENT:",
                },
                new ContentEntity()
                {
                    Text = "Currently, Contoso uses multiple types of servers for business operations, including the following:.",
                },
                new ContentEntity()
                {
                    Text = "* File servers.",
                },
                new ContentEntity()
                {
                    Text = "* Domain controllers.",
                },
                new ContentEntity()
                {
                    Text = "* Microsoft SQL Server servers.",
                },
                new ContentEntity()
                {
                    Text = "Your network contains an Active Directory forest named contoso.com. All servers and client computers are joined to Active Directory. You have a public-facing application named App1. App1 is comprised of the following three tiers:.",
                },
                new ContentEntity()
                {
                    Text = "* A SQL database.",
                },
                new ContentEntity()
                {
                    Text = "* A web front end.",
                },
                new ContentEntity()
                {
                    Text = "* A processing middle tier.",
                },
                new ContentEntity()
                {
                    Text = "Each tier is comprised of five virtual machines. Users access the web front end by using HTTPS only.",
                },
                new ContentEntity()
                {
                    Text = "REQUIREMENTS:",
                },
                new ContentEntity()
                {
                    Text = "PLANNED CHANGES:",
                },
                new ContentEntity()
                {
                    Text = "Contoso plans to implement the following changes to the infrastructure:.",
                },
                new ContentEntity()
                {
                    Text = "* Move all the tiers of App1 to Azure.",
                },
                new ContentEntity()
                {
                    Text = "* Move the existing product blueprint files to Azure Blob storage.",
                },
                new ContentEntity()
                {
                    Text = "* Create a hybrid directory to support an upcoming Microsoft Office 365 migration project.",
                },
                new ContentEntity()
                {
                    Text = "TECHNICAL REQUIREMENTS:",
                },
                new ContentEntity()
                {
                    Text = "Contoso must meet the following technical requirements:.",
                },
                new ContentEntity()
                {
                    Text = "* Move all the virtual machines for App1 to Azure.",
                },
                new ContentEntity()
                {
                    Text = "* Minimize the number of open ports between the App1 tiers.",
                },
                new ContentEntity()
                {
                    Text = "* Ensure that all the virtual machines for App1 are protected by backups.",
                },
                new ContentEntity()
                {
                    Text = "* Copy the blueprint files to Azure over the Internet.",
                },
                new ContentEntity()
                {
                    Text = "* Ensure that the blueprint files are stored in the archive storage tier.",
                },
                new ContentEntity()
                {
                    Text = "* Ensure that partner access to the blueprint files is secured and temporary.",
                },
                new ContentEntity()
                {
                    Text = "* Prevent user passwords or hashes of passwprds from being stored in Azure.",
                },
                new ContentEntity()
                {
                    Text = "* Use unmanaged standard storage for the hard disks of the virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "* Ensure that when users join devices to Azure Active Directory (Azure AD), the users use a mobile phone to verify their identity.",
                },
                new ContentEntity()
                {
                    Text = "* Minimize administrative effort whenever possible.",
                },
                new ContentEntity()
                {
                    Text = "USER REQUIREMENTS:",
                },
                new ContentEntity()
                {
                    Text = "Contoso identifies the following requirements for users:.",
                },
                new ContentEntity()
                {
                    Text = "* Ensure that only users who are part of a group named Pilot can join devices to Azure AD.",
                },
                new ContentEntity()
                {
                    Text = "* Designate a new user named Admin1 as the service admin for the Azure subscription.",
                },
                new ContentEntity()
                {
                    Text = "* Admin1 must receive email alerts regarding service outages.",
                },
                new ContentEntity()
                {
                    Text = "* Ensure that a new user named User3 can create network objects for the Azure subscription.",
                },
                new ContentEntity()
                {
                    Text = "You need to implement a backup solution for App1 after the application is moved.",
                },
                new ContentEntity()
                {
                    Text = "What should you create first?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A recovery plan.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A Recovery Services vault.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "An Azure Backup Server.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A backup policy.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "A Recovery Services vault is a logical container that stores the backup data for each protected resource, such as Azure VMs. When the backup job for a protected resource runs, it creates a recovery point inside the Recovery Services vault."
                },
                new ExplanationEntity()
                {
                    Text = "Scenario:"
                },
                new ExplanationEntity()
                {
                    Text = "There are three application tiers, each with five virtual machines."
                },
                new ExplanationEntity()
                {
                    Text = "Move all the virtual machines for App1 to Azure."
                },
                new ExplanationEntity()
                {
                    Text = "Ensure that all the virtual machines for App1 are protected by backups."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Back up a virtual machine in Azure",
                    Url = "https://docs.microsoft.com/en-us/azure/backup/quick-backup-vm-portal",
                },
            },
        };
    }
}