using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q42Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 42,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "You have several virtual machines in an Azure subscription. You create a new subscription. *** THE VIRTUAL MACHINES CANNOT BE MOVED TO THE NEW SUBSCRIPTION ***.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the UPPER-CASED text surrounded by ***. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The virtual machines can be moved to the new subscription.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "The virtual machines can be moved to the new subscription only if they are all in the same resource group.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The virtual machines can be moved to the new subscription only if they run Windows Server 2016.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Moving between subscriptions can be handy if you originally created a VM in a personal subscription and now want to move it to your company's subscription to continue your work. You do not need to start the VM in order to move it and it should continue to run during the move."
                },
                new ExplanationEntity()
                {
                    Text = "New resource IDs are created as part of the move. After the VM has been moved, you will need to update your tools and scripts to use the new resource IDs."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Move a Windows VM to another Azure subscription or resource group",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-machines/windows/move-vm"
                },
            },
        };
    }
}