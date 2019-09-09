
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        /// <summary>
        /// TO DO
        /// </summary>
        public static QuestionEntity Q75Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 200,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Humongous Insurance is an insurance company that has three offices in Miami, Tokyo and Bangkok. Each office has 5.000 users.",
                },
                new ContentEntity()
                {
                    Text = "Existing Environment.",
                },
                new ContentEntity()
                {
                    Text = "Active Directory Environment.",
                },
                new ContentEntity()
                {
                    Text = "Humongous Insurance has a single-domain Active Directory forest named humongousinsurance.com. The functional level of the forest is Windows Server 2012.",
                },
                new ContentEntity()
                {
                    Text = "You recently provisioned an Azure Active Directory (Azure AD) tenant.",
                },
                new ContentEntity()
                {
                    Text = "Network Infrastructure.",
                },
                new ContentEntity()
                {
                    Text = "Each office has a local data center that contains all the servers for that office. Each office has a dedicated connection to the Internet.",
                },
                new ContentEntity()
                {
                    Text = "Each office has several link load balancers that provide access to the servers.",
                },
                new ContentEntity()
                {
                    Text = "Active Directory Issue.",
                },
                new ContentEntity()
                {
                    Text = "Several users in humongousinsurance.com have UPNs that contain special characters.",
                },
                new ContentEntity()
                {
                    Text = "You suspect that some of the characters are unsupported in Azure AD.",
                },
                new ContentEntity()
                {
                    Text = "Licensing Issue.",
                },
                new ContentEntity()
                {
                    Text = "You attempt to assign a license in Azure to several users and receive the following error message: \"Licenses not assigned. License assignment failed for one user.\".",
                },
                new ContentEntity()
                {
                    Text = "You verify that the Azure subscription has the available licenses.",
                },
                new ContentEntity()
                {
                    Text = "Requirements.",
                },
                new ContentEntity()
                {
                    Text = "Planned Changes.",
                },
                new ContentEntity()
                {
                    Text = "Humongous Insurance plans to open a new office in Paris. The Paris office will contain 1,000 users who will be hired during the next 12 months. All the resources.",
                },
                new ContentEntity()
                {
                    Text = "Used by the Paris office users will be hosted in Azure.",
                },
                new ContentEntity()
                {
                    Text = "Planned Azure AD Infrastructure.",
                },
                new ContentEntity()
                {
                    Text = "The on-premises Active Directory domain will be synchronized to Azure AD.",
                },
                new ContentEntity()
                {
                    Text = "All client computers in the Paris office will be joined to an Azure AD domain.",
                },
                new ContentEntity()
                {
                    Text = "Planned Azure Networking Infrastructure.",
                },
                new ContentEntity()
                {
                    Text = "You plan to create the following networking resources in a resource group named All_Resources:.",
                },
                new ContentEntity()
                {
                    Text = "Default Azure system routes that will be the only routes used to route traffic.",
                },
                new ContentEntity()
                {
                    Text = "A virtual network named Paris-VNet that will contain two subnets named Subnet1 and Subnet2.",
                },
                new ContentEntity()
                {
                    Text = "A virtual network named ClientResources-VNet that will contain one subnet named ClientSubnet.",
                },
                new ContentEntity()
                {
                    Text = "A virtual network named AllOffices-VNet that will contain two subnets named Subnet3 and Subnet4.",
                },
                new ContentEntity()
                {
                    Text = "You plan to enable peering between Paris-VNet and AllOffices-VNet. You will enable the Use remote gateways setting for the Paris-VNet peerings.",
                },
                new ContentEntity()
                {
                    Text = "You plan to create a private DNS zone named humongousinsurance.local and set the registration network to the ClientResources-VNet virtual network.",
                },
                new ContentEntity()
                {
                    Text = "Planned Azure Computer Infrastructure.",
                },
                new ContentEntity()
                {
                    Text = "Each subnet will contain several virtual machines that will run either Windows Server 2012 R2, Windows Server 2016, or Red Hat Linux.",
                },
                new ContentEntity()
                {
                    Text = "Department Requirements.",
                },
                new ContentEntity()
                {
                    Text = "Humongous Insurance identifies the following requirements for the company's departments:.",
                },
                new ContentEntity()
                {
                    Text = "Web administrators will deploy Azure web apps for the marketing department. Each web app will be added to a separate resource group. The initial.",
                },
                new ContentEntity()
                {
                    Text = "Configuration of the web apps will be identical. The web administrators have permission to deploy web apps to resource groups.",
                },
                new ContentEntity()
                {
                    Text = "During the testing phase, auditors in the finance department must be able to review all Azure costs from the past week.",
                },
                new ContentEntity()
                {
                    Text = "Authentication Requirements.",
                },
                new ContentEntity()
                {
                    Text = "Users in the Miami office must use Azure Active Directory Seamless Single Sign-on (Azure AD Seamless SSO) when accessing resources in Azure.",
                },
                new ContentEntity()
                {
                    Text = "You need to resolve the Active Directory issue.",
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
                    Text = "Run the IdFix tool then use the Update actions.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "From Active Directory Domains and Trusts, modify the list of UPN suffixes.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From Azure AD Connect, modify the outbound synchronization rule.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From Active Directory Users and Computers, select the user accounts and then modify the UPN suffix value.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "IdFix is used to perform discovery and remediation of identity objects and their attributes in an on-premises Active Directory environment in preparation for migration"
                },
                new ExplanationEntity()
                {
                    Text = "to Azure Active Directory. IdFix is intended for the Active Directory administrators responsible for directory synchronization with Azure Active Directory."
                },
                new ExplanationEntity()
                {
                    Text = "Scenario: Active Directory Issue"
                },
                new ExplanationEntity()
                {
                    Text = "Several users in humongousinsurance.com have UPNs that contain special characters."
                },
                new ExplanationEntity()
                {
                    Text = "You suspect that some of the characters are unsupported in Azure AD."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://www.microsoft.com/en-us/download/details.aspx?id=36832",
                },
                new ReferenceEntity()
                {
                    Url = "Question Set 1",
                },
            },           
        };
    }
}
