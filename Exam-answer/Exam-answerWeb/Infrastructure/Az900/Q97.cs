using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q97Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 97,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription that contains a policy-based virtual network gateway named GW1 and a virtual network named VNet1.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that you can configure a point-to-site connection from VNet1 to an on-premises computer.",
                },
                new ContentEntity()
                {
                    Text = "Which two actions should you perform? Each correct answer presents part of the solution.",
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
                    Text = "Reset GW1.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create a route-based virtual network gateway.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Delete GW1.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Add a public IP address space to VNet1.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Add a connection to GW1.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Add a service endpoint to VNet1.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "A VPN gateway is used when creating a VPN connection to your on-premises network."
                },
                new ExplanationEntity()
                {
                    Text = "Route-based VPN devices use any-to-any (wildcard) traffic selectors, and let routing/forwarding tables direct traffic to different IPsec tunnels. It is typically built on router platforms where each IPsec tunnel is modeled as a network interface or VTI (virtual tunnel interface)."
                },
                new ExplanationEntity()
                {
                    Text = "Policy-based VPN devices use the combinations of prefixes from both networks to define how traffic is encrypted/decrypted through IPsec tunnels. It is typically built on firewall devices that perform packet filtering. IPsec tunnel encryption and decryption are added to the packet filtering and processing engine."
                },
                new ExplanationEntity()
                {
                    Text = "Point-to-Site connections do not require a VPN device or a public-facing IP address."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Create a route-based VPN gateway using the Azure portal",
                    Url = "https://docs.microsoft.com/en-us/azure/vpn-gateway/create-routebased-vpn-gateway-portal",
                },
                new ReferenceEntity()
                {
                    Text = "Connect Azure VPN gateways to multiple on-premises policy-based VPN devices using PowerShell",
                    Url = "https://docs.microsoft.com/en-us/azure/vpn-gateway/vpn-gateway-connect-multiple-policybased-rm-ps",
                },
            },
        };
    }
}