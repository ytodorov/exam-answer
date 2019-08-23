
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q17Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 23,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have a virtual machine named VM1 that runs Windows Server 2016. VM1 is in the East US Azure region.",
                },
                new ContentEntity()
                {
                    Text = "Which Azure service should you use from the Azure portal to view service failure notifications that can affect the availability of VM1?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Service Fabric.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Monitor.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure virtual machines.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Advisor.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
            },           
        };
    }
}
