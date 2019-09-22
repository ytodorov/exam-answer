using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        /// <summary>
        /// TO DO
        /// </summary>
        public static QuestionEntity Q90Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 239,
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
                    Text = "Contoso creates a new Azure subscription. The Azure Active Directory (Azure AD) tenant uses a domain named contoso.onmicrosoft.com. The tenant uses the P1.",
                },
                new ContentEntity()
                {
                    Text = "Pricing tier.",
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
                    Text = "All the accounts of that respective department. All the user accounts have the department attribute set to their respective department. New users are added.",
                },
                new ContentEntity()
                {
                    Text = "Frequently.",
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
                    Text = "Contoso uses two web applications named App1 and App2. Each instance on each web application requires 1GB of memory.",
                },
                new ContentEntity()
                {
                    Text = "The Azure subscription contains the resources in the following table.",
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
                    Text = "Contoso plans to implement the following changes:.",
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
                    Text = "Note: This question is part of a series of questions that present the same scenario. Each question in the series contains a unique solution that might.",
                },
                new ContentEntity()
                {
                    Text = "Meet the stated goals. Some question sets might have more than one correct solution, while others might not have a correct solution.",
                },
                new ContentEntity()
                {
                    Text = "After you answer a question in this section, you will NOT be able to return to it. As a result, these questions will not appear in the review screen.",
                },
                new ContentEntity()
                {
                    Text = "Your company registers a domain name of contoso.com.",
                },
                new ContentEntity()
                {
                    Text = "You create an Azure DNS zone named contoso.com, and then you add an A record to the zone for a host named www that has an IP address of 131.107.1.10.",
                },
                new ContentEntity()
                {
                    Text = "You discover that Internet hosts are unable to resolve www.contoso.com to the 131.107.1.10 IP address.",
                },
                new ContentEntity()
                {
                    Text = "You need to resolve the name resolution issue.",
                },
                new ContentEntity()
                {
                    Text = "Solution: You modify the SOA record in the contoso.com zone.",
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
                    Text = "Modify the NS record, not the SOA record."
                },
                new ExplanationEntity()
                {
                    Text = "Note: The SOA record stores information about the name of the server that supplied the data for the zone; the administrator of the zone; the current version of the"
                },
                new ExplanationEntity()
                {
                    Text = "data file; the number of seconds a secondary name server should wait before checking for updates; the number of seconds a secondary name server should wait"
                },
                new ExplanationEntity()
                {
                    Text = "before retrying a failed zone transfer; the maximum number of seconds that a secondary name server can use data before it must either be refreshed or expire; and"
                },
                new ExplanationEntity()
                {
                    Text = "a default number of seconds for the time-to-live file on resource records."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://searchnetworking.techtarget.com/definition/start-of-authority-record",
                },
            },
        };
    }
}