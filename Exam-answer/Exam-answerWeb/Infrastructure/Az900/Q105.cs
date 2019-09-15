using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q104Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 240,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription that contains three virtual networks named VNet1, VNet2, and VNet3. VNet2 contains a virtual appliance named VM2 that operates as a router.",
                },
                new ContentEntity()
                {
                    Text = "You are configuring the virtual networks in a hub and spoke topology that uses VNet2 as the hub network.",
                },
                new ContentEntity()
                {
                    Text = "You plan to configure peering between VNet1 and Vnet2 and between VNet2 and VNet3.",
                },
                new ContentEntity()
                {
                    Text = "You need to provide connectivity between VNet1 and VNet3 through VNet2.",
                },
                new ContentEntity()
                {
                    Text = "Which two configurations should you perform? Each correct answer presents part of the solution.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "On the peering connections, use remote gateways.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "On the peering connections, allow forwarded traffic.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "On the peering connections, allow gateway transit.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create route tables and assign the table to subnets.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create a route filter.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Allow gateway transit: Check this box if you have a virtual network gateway attached to this virtual network and want to allow traffic from the peered virtual network to flow through the gateway. For example, this virtual network may be attached to an on-premises network through a virtual network gateway. The gateway can be an ExpressRoute or VPN gateway. Checking this box allows traffic from the peered virtual network to flow through the gateway attached to this virtual network to the on-premises network. If you check this box, the peered virtual network cannot have a gateway configured. The peered virtual network must have the Use remote gateways checkbox checked when setting up the peering from the other virtual network to this virtual network. If you leave this box unchecked (default), traffic from the peered virtual network still flows to this virtual network, but cannot flow through a virtual network gateway attached to this virtual network. If the peering is between a virtual network (Resource Manager) and a virtual network (classic), the gateway must be in the virtual network (Resource Manager)."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Create, change, or delete a virtual network peering",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-manage-peering#requirements-and-constraints",
                },
            },
        };
    }
}