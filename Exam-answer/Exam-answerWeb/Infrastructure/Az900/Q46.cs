using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q46Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 46,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company has an Azure subscription that contains the following unused resources:",
                },
                new ContentEntity()
                {
                    Text = "20 user accounts in Azure Active Directory (Azure AD).",
                },
                new ContentEntity()
                {
                    Text = "Five groups in Azure AD.",
                },
                new ContentEntity()
                {
                    Text = "10 public IP addresses.",
                },
                new ContentEntity()
                {
                    Text = "10 network interfaces.",
                },
                new ContentEntity()
                {
                    Text = "You need to reduce the Azure costs for the company.",
                },
                new ContentEntity()
                {
                    Text = "Solution: You remove the unused network interfaces.",
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "No.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "When creating a virtual machine using the Azure portal, the portal creates a network interface with default settings for you. If you'd rather specify all your network interface settings, you can create a network interface with custom settings and attach the network interface to a virtual machine when creating the virtual machine (using PowerShell or the Azure CLI). You can also create a network interface and add it to an existing virtual machine (using PowerShell or the Azure CLI). To learn how to create a virtual machine with an existing network interface or to add to, or remove network interfaces from existing virtual machines, see Add or remove network interfaces. Before creating a network interface, you must have an existing virtual network in the same location and subscription you create a network interface in."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Reduce costs by deleting or reconfiguring idle virtual network gateways",
                    Url = "https://docs.microsoft.com/en-us/azure/advisor/advisor-cost-recommendations#reduce-costs-by-deleting-or-reconfiguring-idle-virtual-network-gateways",
                },
            },
        };
    }
}