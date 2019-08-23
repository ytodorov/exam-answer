
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q108Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 244,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company has a main office in London that contains 100 client computers.",
                },
                new ContentEntity()
                {
                    Text = "Three years ago, you migrated to Azure Active Directory (Azure AD).",
                },
                new ContentEntity()
                {
                    Text = "The company’s security policy states that all personal devices and corporate-owned devices must be registered or joined to Azure AD.",
                },
                new ContentEntity()
                {
                    Text = "A remote user named User1 is unable to join a personal device to Azure AD from a home network.",
                },
                new ContentEntity()
                {
                    Text = "You verify that other users can join their devices to Azure AD.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that User1 can join the device to Azure AD.",
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
                    Text = "From the Device settings blade, modify the Users may join devices to Azure AD setting.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From the Device settings blade, modify the Maximum number of devices per user setting.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a point-to-site VPN from the home network of User1 to Azure.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Assign the User administrator role to User1.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "The Maximum number of devices setting enables you to select the maximum number of devices that a user can have in Azure AD. If a user reaches this quota, they"
                },
                new ExplanationEntity()
                {
                    Text = "will not be able to add additional devices until one or more of the existing devices are removed."
                },
                new ExplanationEntity()
                {
                    Text = "Incorrect Answers:"
                },
                new ExplanationEntity()
                {
                    Text = "A: The Users may join devices to Azure AD setting enables you to select the users who can join devices to Azure AD. Options are All, Selected and None. The"
                },
                new ExplanationEntity()
                {
                    Text = "default is All."
                },
                new ExplanationEntity()
                {
                    Text = "C: Azure AD Join enables users to join their devices to Active Directory from anywhere as long as they have connectivity with the Internet."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/devices/device-management-azure-portal",
                },
                new ReferenceEntity()
                {
                    Url = "http://techgenix.com/pros-and-cons-azure-ad-join/",
                },
            },           
        };
    }
}
