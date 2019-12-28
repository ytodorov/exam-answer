using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q89Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 240,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Contoso, Ltd. is a consulting company that has a main office in Montreal and two branch offices in Seattle and New York.",
                },
                new ContentEntity()
                {
                    Text = "The Montreal office has 2,000 employees. The Seattle office has 1,000 employees. The New York office has 200 employees.",
                },
                new ContentEntity()
                {
                    Text = "All the resources used by Contoso are hosted on-premises.",
                },
                new ContentEntity()
                {
                    Text = "Contoso creates a new Azure subscription. The Azure Active Directory (Azure AD) tenant uses a domain named contoso.onmicrosoft.com. The tenant uses the P1 pricing tier.",
                },
                new ContentEntity()
                {
                    Text = "Existing Environment.",
                },
                new ContentEntity()
                {
                    Text = "The network contains an Active Directory forest named contoso.com. All domain controllers are configured as DNS servers and host the contoso.com DNS zone.",
                },
                new ContentEntity()
                {
                    Text = "Contoso has finance, human resources, sales, research, and information technology departments. Each department has an organizational unit (OU) that contains.",
                },
                new ContentEntity()
                {
                    Text = "All the accounts of that respective department. All the user accounts have the department attribute set to their respective department. New users are added frequently.",
                },
                new ContentEntity()
                {
                    Text = "Contoso.com contains a user named User1.",
                },
                new ContentEntity()
                {
                    Text = "All the offices connect by using private links.",
                },
                new ContentEntity()
                {
                    Text = "Contoso has data centers in the Montreal and Seattle offices. Each data center has a firewall that can be configured as a VPN device.",
                },
                new ContentEntity()
                {
                    Text = "All infrastructure servers are virtualized. The virtualization environment contains the servers in the following table.",
                },
                new ContentEntity()
                {
                    Text = "Name: Server1, Role: VMWare vCenter server, Container virtual machine: VM1"
                },
                new ContentEntity()
                {
                    Text = "Name: Server2, Role: Hyper-V-host, Container virtual machine: VM2"
                },
                new ContentEntity()
                {
                    Text = "Contoso uses two web applications named App1 and App2. Each instance on each web application requires 1GB of memory.",
                },
                new ContentEntity()
                {
                    Text = "The Azure subscription contains the resources in the following table.",
                },
                new ContentEntity()
                {
                    Text = "Name: VNet1, Type: Virtual network",
                },
                new ContentEntity()
                {
                    Text = "Name: VM3, Type: Virtual machine",
                },
                 new ContentEntity()
                {
                    Text = "Name: VM4, Type: Virtual machine",
                },
                new ContentEntity()
                {
                    Text = "The network security team implements several network security groups (NSGs).",
                },
                new ContentEntity()
                {
                    Text = "Planned Changes.",
                },
                new ContentEntity()
                {
                    Text = "Contoso plans to implement the following changes:",
                },
                new ContentEntity()
                {
                    Text = "Deploy Azure ExpressRoute to the Montreal office.",
                },
                new ContentEntity()
                {
                    Text = "Migrate the virtual machines hosted on Server1 and Server2 to Azure.",
                },
                new ContentEntity()
                {
                    Text = "Synchronize on-premises Active Directory to Azure Active Directory (Azure AD).",
                },
                new ContentEntity()
                {
                    Text = "Migrate App1 and App2 to two Azure web apps named WebApp1 and WebApp2.",
                },
                new ContentEntity()
                {
                    Text = "Technical requirements.",
                },
                new ContentEntity()
                {
                    Text = "Contoso must meet the following technical requirements:.",
                },
                new ContentEntity()
                {
                    Text = "Ensure that WebApp1 can adjust the number of instances automatically based on the load and can scale up to five instances.",
                },
                new ContentEntity()
                {
                    Text = "Ensure that VM3 can establish outbound connections over TCP port 8080 to the applications servers in the Montreal office.",
                },
                new ContentEntity()
                {
                    Text = "Ensure that routing information is exchanged automatically between Azure and the routers in the Montreal office.",
                },
                new ContentEntity()
                {
                    Text = "Ensure Azure Multi-Factor Authentication (MFA) for the users in the finance department only.",
                },
                new ContentEntity()
                {
                    Text = "Ensure that webapp2.azurewebsites.net can be accessed by using the name app2.contoso.com.",
                },
                new ContentEntity()
                {
                    Text = "Connect the New York office to VNet1 over the Internet by using an encrypted connection.",
                },
                new ContentEntity()
                {
                    Text = "Create a workflow to send an email message when the settings of VM4 are modified.",
                },
                new ContentEntity()
                {
                    Text = "Create a custom Azure role named Role1 that is based on the Reader role.",
                },
                new ContentEntity()
                {
                    Text = "Minimize costs whenever possible.",
                },
                new ContentEntity()
                {
                    Text = "You discover that VM3 does NOT meet the technical requirements.",
                },
                new ContentEntity()
                {
                    Text = "You need to verify whether the issue relates to the NSGs.",
                },
                new ContentEntity()
                {
                    Text = "What should you use?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Diagram in VNet1.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The security recommendations in Azure Advisor.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Diagnostic settings in Azure Monitor.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Diagnose and solve problems in Traffic Manager profiles.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "IP flow verify in Azure Network Watcher.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Scenario: Contoso must meet technical requirements including:"
                },
                new ExplanationEntity()
                {
                    Text = "Ensure that VM3 can establish outbound connections over TCP port 8080 to the applications servers in the Montreal office."
                },
                new ExplanationEntity()
                {
                    Text = "IP flow verify checks if a packet is allowed or denied to or from a virtual machine. The information consists of direction, protocol, local IP, remote IP, local port, and remote port. If the packet is denied by a security group, the name of the rule that denied the packet is returned. While any source or destination IP can be chosen, IP flow verify helps administrators quickly diagnose connectivity issues from or to the internet and from or to the on-premises environment."
                },
                new ExplanationEntity()
                {
                    Text = "IP flow verify looks at the rules for all Network Security Groups (NSGs) applied to the network interface, such as a subnet or virtual machine NIC. Traffic flow is then verified based on the configured settings to or from that network interface. IP flow verify is useful in confirming if a rule in a Network Security Group is blocking ingress or egress traffic to or from a virtual machine.",
                },
                new ExplanationEntity()
                {
                    Text = "An instance of Network Watcher needs to be created in all regions that you plan to run IP flow verify. Network Watcher is a regional service and can only be ran against resources in the same region. The instance used does not affect the results of IP flow verify, as any route associated with the NIC or subnet is still be returned.",
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Introduction to IP flow verify in Azure Network Watcher",
                    Url = "https://docs.microsoft.com/en-us/azure/network-watcher/network-watcher-ip-flow-verify-overview",
                },
            },
        };
    }
}