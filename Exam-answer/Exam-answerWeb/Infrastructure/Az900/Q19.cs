using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q18Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 24,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "An Azure administrator plans to run a PowerShell script that creates Azure resources.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend which computer configuration to use to run the script.",
                },
                new ContentEntity()
                {
                    Text = "Solution: Run the script from a computer that runs Linux and has the Azure CLI tools installed.",
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
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "No.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Install Azure CLI on Linux manually"
                },
                new ExplanationEntity()
                {
                    Text = "If there's no package for the Azure CLI for your distribution, install the CLI manually by running a script."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Install Azure CLI on Linux manually",
                    Url = "https://docs.microsoft.com/bs-latn-ba/cli/azure/install-azure-cli-linux?view=azure-cli-latest"
                },
            },
        };
    }
}