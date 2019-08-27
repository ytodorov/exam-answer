
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q20Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 28,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure environment that contains multiple Azure virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "You plan to implement a solution that enables the client computers on your on-premises network to communicate to the Azure virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend which Azure resources must be created for the planned solution.",
                },
                new ContentEntity()
                {
                    Text = "Which two Azure resources should you include in the recommendation? Each correct answer presents part of the solution.",
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
                    Text = "A virtual network gateway.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A load balancer.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An application gateway.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A virtual network.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A gateway subnet.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "A VPN gateway is a specific type of virtual network gateway that is used to send encrypted traffic between an Azure virtual network and an on-premises location over the public Internet. You can also use a VPN gateway to send encrypted traffic between Azure virtual networks over the Microsoft network. Each virtual network can have only one VPN gateway. However, you can create multiple connections to the same VPN gateway. When you create multiple connections to the same VPN gateway, all VPN tunnels share the available gateway bandwidth."
                },
                new ExplanationEntity()
                {
                    Text = "A virtual network gateway is composed of two or more virtual machines that are deployed to a specific subnet you create, which is called the gateway subnet. The VMs that are located in the gateway subnet are created when you create the virtual network gateway. Virtual network gateway VMs are configured to contain routing tables and gateway services specific to the gateway. You can't directly configure the VMs that are part of the virtual network gateway and you should never deploy additional resources to the gateway subnet."
                },
                new ExplanationEntity()
                {
                    Text = "VPN gateways can be deployed in Azure Availability Zones. This brings resiliency, scalability, and higher availability to virtual network gateways. Deploying gateways in Azure Availability Zones physically and logically separates gateways within a region, while protecting your on-premises network connectivity to Azure from zone-level failures. "
                },                
            },

            References = new List<ReferenceEntity>()
            {
                 new ReferenceEntity()
                {
                    Text = "Connect an on-premises network to a Microsoft Azure virtual network",
                    Url = "https://docs.microsoft.com/en-us/office365/enterprise/connect-an-on-premises-network-to-a-microsoft-azure-virtual-network",
                },
                new ReferenceEntity()
                {
                    Text = "What is VPN Gateway?",
                    Url = "https://docs.microsoft.com/en-us/azure/vpn-gateway/vpn-gateway-about-vpngateways",
                },
            },           
        };
    }
}
