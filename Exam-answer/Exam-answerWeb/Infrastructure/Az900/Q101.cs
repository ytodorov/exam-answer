
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
                    Text = "You have an Azure subscription named Subscription1 that contains two Azure virtual networks named VNet1 and VNet2. VNet1 contains a VPN gateway named.",
                },
                new ContentEntity()
                {
                    Text = "VPNGW1 that uses static routing. There is a site-to-site VPN connection between your on-premises network and VNet1.",
                },
                new ContentEntity()
                {
                    Text = "On a computer named Client1 that runs Windows 10, you configure a point-to-site VPN connection to VNet1.",
                },
                new ContentEntity()
                {
                    Text = "You configure virtual network peering between VNet1 and VNet2. You verify that you can connect to VNet2 from the on-premises network. Client1 is unable to.",
                },
                new ContentEntity()
                {
                    Text = "Connect to VNet2.",
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
                    Url = "https://docs.microsoft.com/en-us/azure/vpn-gateway/vpn-gateway-about-point-to-site-routing",
                },
            },           
        };
    }
}
