
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q92Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 225,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have two subscriptions named Subscription1 and Subscription2. Each subscription is associated to a different Azure AD tenant.",
                },
                new ContentEntity()
                {
                    Text = "Subscription1 contains a virtual network named VNet1. VNet1 contains an Azure virtual machine named VM1 and has an IP address space of 10.0.0.0/16.",
                },
                new ContentEntity()
                {
                    Text = "Subscription2 contains a virtual network named VNet2. VNet2 contains an Azure virtual machine named VM2 and has an IP address space of 10.10.0.0/24.",
                },
                new ContentEntity()
                {
                    Text = "You need to connect VNet1 to VNet2.",
                },
                new ContentEntity()
                {
                    Text = "What should you do first?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Move VM1 to Subscription2.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Modify the IP address space of VNet2.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Provision virtual network gateways.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Move VNet1 to Subscription2.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "The virtual networks can be in the same or different regions, and from the same or different subscriptions. When connecting VNets from different subscriptions, the subscriptions do not need to be associated with the same Active Directory tenant."
                },
                new ExplanationEntity()
                {
                    Text = "Configuring a VNet-to-VNet connection is a good way to easily connect VNets. Connecting a virtual network to another virtual network using the VNet-to-VNet connection type (VNet2VNet) is similar to creating a Site-to-Site IPsec connection to an on-premises location. Both connectivity types use a VPN gateway to provide a secure tunnel using IPsec/IKE, and both function the same way when communicating."
                },
                new ExplanationEntity()
                {
                    Text = "The local network gateway for each VNet treats the other VNet as a local site. This lets you specify additional address space for the local network gateway in order to route traffic."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Configure a VNet-to-VNet VPN gateway connection by using the Azure portal",
                    Url = "https://docs.microsoft.com/en-us/azure/vpn-gateway/vpn-gateway-howto-vnet-vnet-resource-manager-portal",
                },
            },           
        };
    }
}
