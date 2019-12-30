using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q50Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 50,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your Azure environment contains multiple Azure virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that a virtual machine named VM1 is accessible from the Internet over HTTP.",
                },
                new ContentEntity()
                {
                    Text = "Solution: You modify a DDoS protection plan.",
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
                    Text = "You open a port, or create an endpoint, to a virtual machine (VM) in Azure by creating a network filter on a subnet or a VM network interface. You place these filters, which control both inbound and outbound traffic, on a network security group attached to the resource that receives the traffic."
                },
                new ExplanationEntity()
                {
                    Text = "The example in this article demonstrates how to create a network filter that uses the standard TCP port 80 (it's assumed you've already started the appropriate services and opened any OS firewall rules on the VM)."
                },
                new ExplanationEntity()
                {
                    Text = "After you've created a VM that's configured to serve web requests on the standard TCP port 80, you can:"
                },
                new ExplanationEntity()
                {
                    Text = "1. Create a network security group."
                },
                new ExplanationEntity()
                {
                    Text = "2. Create an inbound security rule allowing traffic and assign values to the following settings:"
                },
                new ExplanationEntity()
                {
                    Text = "a. Destination port ranges: 80."
                },
                new ExplanationEntity()
                {
                    Text = "b. Source port ranges: * (allows any source port)."
                },
                new ExplanationEntity()
                {
                    Text = "c. Priority value: Enter a value that is less than 65,500 and higher in priority than the default catch-all deny inbound rule."
                },
                new ExplanationEntity()
                {
                    Text = "Associate the network security group with the VM network interface or subnet."
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="How to open ports to a virtual machine with the Azure portal",
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-machines/windows/nsg-quickstart-portal"
                },
                new ReferenceEntity()
                {
                    Text ="Tutorial: Deploy and configure Azure Firewall using the Azure portal",
                    Url = "https://docs.microsoft.com/en-us/azure/firewall/tutorial-firewall-deploy-portal"
                }
            },
        };
    }
}