using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q83Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 83,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription that contains a virtual machine named VM1. VM1 hosts a line-of-business application that is available 24 hours a day. VM1 has one network interface and one managed disk. VM1 uses the D4s v3 size.",
                },
                new ContentEntity()
                {
                    Text = "You plan to make the following changes to VM1:",
                },
                new ContentEntity()
                {
                    Text = "* Change the size to D8s v3.",
                },
                new ContentEntity()
                {
                    Text = "* Add a 500-GB managed disk.",
                },
                new ContentEntity()
                {
                    Text = "* Add the Puppet Agent extension.",
                },
                new ContentEntity()
                {
                    Text = "* Attach an additional network interface.",
                },
                new ContentEntity()
                {
                    Text = "Which change will cause downtime for VM1?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Add the Puppet Agent extension.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Change the size to D8s v3.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Add a 500-GB managed disk.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Attach an additional network interface.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "While resizing the VM it must be in a stopped state."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Resize virtual machines",
                    Url = "https://azure.microsoft.com/en-us/blog/resize-virtual-machines/",
                },
            },
        };
    }
}