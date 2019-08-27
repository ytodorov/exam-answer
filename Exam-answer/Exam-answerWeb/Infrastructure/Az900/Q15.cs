
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q14Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 20,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "You plan to deploy 20 virtual machines to an Azure environment. To ensure that a virtual machine named VM1 cannot connect to the other virtual machines, VM1 must *** BE DEPLOYED TO A SEPARATE VIRTUAL NETWORK ***.",
                },
                new ContentEntity()
                {
                    Text = "Must be deployed to a separate virtual network.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Run a different operating system than the other virtual machines.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Be deployed to a separate resource group.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Have two network interfaces.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure Virtual Network (VNet) is the fundamental building block for your private network in Azure. VNet enables many types of Azure resources, such as Azure Virtual Machines (VM), to securely communicate with each other, the internet, and on-premises networks. VNet is similar to a traditional network that you'd operate in your own data center, but brings with it additional benefits of Azure's infrastructure such as scale, availability, and isolation."
                },
                new ExplanationEntity()
                {
                    Text = "VNet concepts:"
                },
                new ExplanationEntity()
                {
                    Text = "Address space: When creating a VNet, you must specify a custom private IP address space using public and private (RFC 1918) addresses. Azure assigns resources in a virtual network a private IP address from the address space that you assign. For example, if you deploy a VM in a VNet with address space, 10.0.0.0/16, the VM will be assigned a private IP like 10.0.0.4."
                },
                new ExplanationEntity()
                {
                    Text = "Subnets: Subnets enable you to segment the virtual network into one or more sub-networks and allocate a portion of the virtual network's address space to each subnet. You can then deploy Azure resources in a specific subnet. Just like in a traditional network, subnets allow you to segment your VNet address space into segments that are appropriate for the organization's internal network. This also improves address allocation efficiency. You can secure resources within subnets using Network Security Groups. For more information, see Security groups."
                },
                new ExplanationEntity()
                {
                    Text = "Regions: VNet is scoped to a single region/location; however, multiple virtual networks from different regions can be connected together using Virtual Network Peering."
                },
                new ExplanationEntity()
                {
                    Text = "Subscription: VNet is scoped to a subscription. You can implement multiple virtual networks within each Azure subscription and Azure region."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "What is Azure Virtual Network?",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/virtual-networks-overview"
                },
                new ReferenceEntity()
                {
                    Text = "Virtual Network Documentation",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/"
                },
            },           
        };
    }
}
