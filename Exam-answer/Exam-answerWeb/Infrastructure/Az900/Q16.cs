using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q16Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 16,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A support engineer plans to perform several Azure management tasks by using the Azure CLI.",
                },
                new ContentEntity()
                {
                    Text = "You install the CLI on a computer.",
                },
                new ContentEntity()
                {
                    Text = "You need to tell the support engineer which tools to use to run the CLI.",
                },
                new ContentEntity()
                {
                    Text = "Which two tools should you instruct the support engineer to use? Each correct answer presents a complete solution.",
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
                    Text = "Command Prompt.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Resource Explorer.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Windows PowerShell.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Windows Defender Firewall.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Network and Sharing Center.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "For Windows the Azure CLI is installed via an MSI, which gives you access to the CLI through the Windows Command Prompt (CMD) or PowerShell. When installing for Windows Subsystem for Linux (WSL), packages are available for your Linux distribution. "
                },
                new ExplanationEntity()
                {
                    Text = "The Azure CLI is a command-line tool providing a great experience for managing Azure resources. The CLI is designed to make scripting easy, query data, support long-running operations, and more."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Install Azure CLI on Windows",
                    Url = "https://docs.microsoft.com/en-us/cli/azure/install-azure-cli-windows?view=azure-cli-latest"
                },
                new ReferenceEntity()
                {
                    Text = "Get started with Azure CLI",
                    Url = "https://docs.microsoft.com/en-us/cli/azure/get-started-with-azure-cli?view=azure-cli-latest"
                },
            },
        };
    }
}