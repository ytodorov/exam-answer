
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q93Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 226,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription that contains the resources in the following table.",
                },
                new ContentEntity()
                {
                    Text = "To which subnets can you apply NSG1?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The subnets on VNet2 only.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The subnets on VNet2 and VNet3 only.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The subnets on VNet1, VNet2, and VNet3.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The subnets on VNet1 only.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The subnets on VNet3 only.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "All Azure resources are created in an Azure region and subscription. A resource can only be created in a virtual network that exists in the same region and"
                },
                new ExplanationEntity()
                {
                    Text = "subscription as the resource."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-vnet-plan-design-arm",
                },
            },           
        };
    }
}
