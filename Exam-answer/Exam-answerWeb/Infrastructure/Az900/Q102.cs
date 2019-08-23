
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q101Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 237,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription that contains the resources in the following table.",
                },
                new ContentEntity()
                {
                    Text = "VM1 and VM2 are deployed from the same template and host line-of-business applications accessed by using Remote Desktop.",
                },
                new ContentEntity()
                {
                    Text = "You configure the network security group (NSG) shown in the exhibit. (Click the Exhibit tab.).",
                },
                new ContentEntity()
                {
                    Text = "You need to prevent users of VM2 and VM2 from accessing websites on the Internet over TCP port 80.",
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
                    Text = "Change the DenyWebSites outbound security rule.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Change the Port_80 inbound security rule.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Disassociate the NSG from a network interface.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Associate the NSG to Subnet1.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You can associate or dissociate a network security group from a network interface or subnet."
                },
                new ExplanationEntity()
                {
                    Text = "The NSG has the appropriate rule to block users from accessing the Internet. We just need to associate it with Subnet1."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/manage-network-security-group",
                },
            },           
        };
    }
}
