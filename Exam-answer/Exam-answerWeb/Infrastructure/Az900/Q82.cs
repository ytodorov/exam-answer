using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q82Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 82,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You plan to automate the deployment of a virtual machine scale set that uses the Windows Server 2016 Datacenter image.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that when the scale set virtual machines are provisioned, they have web server components installed.",
                },
                new ContentEntity()
                {
                    Text = "Which two actions should you perform? Each correct answer presents part of the solution.",
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
                    Text = "Modify the extensionProfile section of the Azure Resource Manager template.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create an automation account.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Upload a configuration script.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create a new virtual machine scale set in the Azure portal.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create an Azure policy.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Virtual Machine Scale Sets can be used with the Azure Desired State Configuration (DSC) extension handler. Virtual machine scale sets provide a way to deploy and manage large numbers of virtual machines, and can elastically scale in and out in response to load. DSC is used to configure the VMs as they come online so they are running the production software."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Using Virtual Machine Scale Sets with the Azure DSC Extension",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-dsc",
                },
            },
        };
    }
}