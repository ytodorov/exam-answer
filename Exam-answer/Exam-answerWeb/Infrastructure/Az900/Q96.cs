using DAL.Entities;
using System.Collections.Generic;
using Exam_answerWeb.Extensions;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q95Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 228,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have the Azure virtual networks shown in the following table.",
                },
                new ContentEntity()
                {
                    Text = "***",
                },
                new ContentEntity()
                {
                    Text = "Name: VNet1,".PadRightEA() + "Address space: 10.11.0.0/16,".PadRightEA() + "Subnet: 10.11.0.0/17,".PadRightEA() + "Azure Region: West US",
                },
                new ContentEntity()
                {
                    Text = "Name: VNet2,".PadRightEA() + "Address space: 10.11.0.0/17,".PadRightEA() + "Subnet: 10.11.0.0/25,".PadRightEA() + "Azure Region: West US",
                },
                new ContentEntity()
                {
                    Text = "Name: VNet3,".PadRightEA() + "Address space: 10.10.0.0/22,".PadRightEA() + "Subnet: 10.10.1.0/24,".PadRightEA() + "Azure Region: East US",
                },
                new ContentEntity()
                {
                    Text = "Name: VNet4,".PadRightEA() +"Address space: 192.168.16.0/22,".PadRightEA() +"Subnet: 192.168.16.0/24,".PadRightEA() + "Azure Region: North Europe",
                },
                new ContentEntity()
                {
                    Text = "***",
                },
                new ContentEntity()
                {
                    Text = "To which virtual networks can you establish a peering connection from VNet1?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "VNet2 and VNet3 only.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "VNet2 only.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "VNet3 and VNet4 only.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "VNet2, VNet3, and VNet4.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You can connect virtual networks to each other with virtual network peering. These virtual networks can be in the same region or different regions (also known as Global VNet peering). Once virtual networks are peered, resources in both virtual networks are able to communicate with each other, with the same latency and bandwidth as if the resources were in the same virtual network."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Tutorial: Connect virtual networks with virtual network peering using the Azure portal",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/tutorial-connect-virtual-networks-portal",
                },
            },
        };
    }
}