using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q100Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 235,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Subscription1 that contains two Azure virtual networks named VNet1 and VNet2. VNet1 contains a VPN gateway named VPNGW1 that uses static routing. There is a site-to-site VPN connection between your on-premises network and VNet1.",
                },
                new ContentEntity()
                {
                    Text = "On a computer named Client1 that runs Windows 10, you configure a point-to-site VPN connection to VNet1.",
                },
                new ContentEntity()
                {
                    Text = "You configure virtual network peering between VNet1 and VNet2. You verify that you can connect to VNet2 from the on-premises network. Client1 is unable to connect to VNet2.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that you can connect Client1 to VNet2.",
                },
                new ContentEntity()
                {
                    Text = "What should you do?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Select Allow gateway transit on VNet2.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Enable BGP on VPNGW1.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Select Allow gateway transit on VNet1.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Download and re-install the VPN client configuration package on Client1.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "P2S VPN routing behavior is dependent on the client OS, the protocol used for the VPN connection, and how the virtual networks (VNets) are connected to each other."
                },
                new ExplanationEntity()
                {
                    Text = "Azure currently supports two protocols for remote access, IKEv2 and SSTP. IKEv2 is supported on many client operating systems including Windows, Linux, MacOS, Android, and iOS. SSTP is only supported on Windows. If you make a change to the topology of your network and have Windows VPN clients, the VPN client package for Windows clients must be downloaded and installed again in order for the changes to be applied to the client."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "About Point-to-Site VPN routing",
                    Url = "https://docs.microsoft.com/en-us/azure/vpn-gateway/vpn-gateway-about-point-to-site-routing",
                },
            },
        };
    }
}