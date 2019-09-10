
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q87Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 218,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure virtual machine named VM1. VM1 was deployed by using a custom Azure Resource Manager template named ARM1.json.",
                },
                new ContentEntity()
                {
                    Text = "You receive a notification that VM1 will be affected by maintenance.",
                },
                new ContentEntity()
                {
                    Text = "You need to move VM1 to a different host immediately.",
                },
                new ContentEntity()
                {
                    Text = "Solution: From the Redeploy blade, you click Redeploy.",
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
                    Text = "When you redeploy a VM, it moves the VM to a new node within the Azure infrastructure and then powers it back on, retaining all your configuration options and associated resources."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Redeploy Windows virtual machine to new Azure node",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-machines/windows/redeploy-to-new-node",
                },
            },           
        };
    }
}
