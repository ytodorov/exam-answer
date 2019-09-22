using DAL.Entities;
using System.Collections.Generic;
using Exam_answerWeb.Extensions;

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
                    Text = "***",
                },
                new ContentEntity()
                {
                    Text = "Name: VNet1,".PadRightEA() + "Type: virtual network".PadRightEA() + "Azure region: West US".PadRightEA() + "Resource group: RG2"
                },
                new ContentEntity()
                {
                    Text = "Name: VNet2,".PadRightEA() + "Type: virtual network".PadRightEA() + "Azure region: West US".PadRightEA() + "Resource group: RG1"
                },
                new ContentEntity()
                {
                    Text = "Name: VNet3,".PadRightEA() + "Type: virtual network".PadRightEA() + "Azure region: East US".PadRightEA() + "Resource group: RG1"
                },
                new ContentEntity()
                {
                    Text = "Name: NSG1,".PadRightEA() + "Type: Network security group (NSG)".PadRightEA() + "Azure region: East US".PadRightEA() + "Resource group: RG2"
                },
                new ContentEntity()
                {
                    Text = "***",
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
                    Text = "All Azure resources are created in an Azure region and subscription. A resource can only be created in a virtual network that exists in the same region and subscription as the resource. You can however, connect virtual networks that exist in different subscriptions and regions. For more information, see connectivity. When deciding which region(s) to deploy resources in, consider where consumers of the resources are physically located:"
                },
                new ExplanationEntity()
                {
                    Text = "Consumers of resources typically want the lowest network latency to their resources. To determine relative latencies between a specified location and Azure regions, see View relative latencies."
                },
                new ExplanationEntity()
                {
                    Text = "Do you have data residency, sovereignty, compliance, or resiliency requirements? If so, choosing the region that aligns to the requirements is critical. ",
                },
                new ExplanationEntity()
                {
                    Text = "Do you require resiliency across Azure Availability Zones within the same Azure region for the resources you deploy? You can deploy resources, such as virtual machines (VM) to different availability zones within the same virtual network. Not all Azure regions support availability zones however. "
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Plan virtual networks",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-vnet-plan-design-arm",
                },
            },
        };
    }
}