
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q84Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 214,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Subscription1.",
                },
                new ContentEntity()
                {
                    Text = "You deploy a Linux virtual machine named VM1 to Subscription1.",
                },
                new ContentEntity()
                {
                    Text = "You need to monitor the metrics and the logs of VM1.",
                },
                new ContentEntity()
                {
                    Text = "What should you use?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The AzurePerformanceDiagnostics extension.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure HDInsight.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Linux Diagnostic Extension (LAD) 3.0.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Analysis Services.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You can use extensions to configure diagnostics on your VMs to collect additional metric data."
                },
                new ExplanationEntity()
                {
                    Text = "The basic host metrics are available, but to see more granular and VM-specific metrics, you need to install the Azure diagnostics extension on the VM. The Azure diagnostics extension allows additional monitoring and diagnostics data to be retrieved from the VM."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Tutorial: Monitor and update a Linux virtual machine in Azure",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-machines/linux/tutorial-monitoring",
                },
            },           
        };
    }
}
