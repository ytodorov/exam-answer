
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q97Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 230,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Subscription1 that contains the resource groups shown in the following table.",
                },
                new ContentEntity()
                {
                    Text = "In RG1, you create a virtual machine named VM1 in the East Asia location.",
                },
                new ContentEntity()
                {
                    Text = "You plan to create a virtual network named VNET1.",
                },
                new ContentEntity()
                {
                    Text = "You need to create VNET1, and then connect VM1 to VNET1.",
                },
                new ContentEntity()
                {
                    Text = "What are two possible ways to achieve this goal? Each correct answer presents a complete solution.",
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
                    Text = "Create VNET1 in RG2, and then set East Asia as the location.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create VNET1 in a new resource group in the West US location, and then set West US as the location.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create VNET1 in RG1, and then set East US as the location.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create VNET1 in RG2, and then set East US as the location.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create VNET1 in RG1, and then set East Asia as the location.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="",
                    Url = ""
                },
                new ReferenceEntity()
                {
                    Text ="",
                    Url = ""
                }
            },                
        };
    }
}
