using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q13Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 13,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure environment. You need to create a new Azure virtual machine from an Android laptop.",
                },
                new ContentEntity()
                {
                    Text = "Solution: You use PowerShell in Azure Cloud Shell.",
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "No.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "PowerShell is a task-based command-line shell and scripting language built on .NET. PowerShell helps system administrators and power-users rapidly automate tasks that manage operating systems (Linux, macOS, and Windows) and processes."
                },
                new ExplanationEntity()
                {
                    Text = "PowerShell commands let you manage computers from the command line. PowerShell providers let you access data stores, such as the registry and certificate store, as easily as you access the file system. PowerShell includes a rich expression parser and a fully developed scripting language."
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Quickstart for PowerShell in Azure Cloud Shell",
                    Url = "https://docs.microsoft.com/en-us/azure/cloud-shell/quickstart-powershell"
                },
                new ReferenceEntity()
                {
                    Text ="PowerShell Scripting",
                    Url = "https://docs.microsoft.com/en-us/powershell/scripting/overview?view=powershell-6"
                }
            },
        };
    }
}