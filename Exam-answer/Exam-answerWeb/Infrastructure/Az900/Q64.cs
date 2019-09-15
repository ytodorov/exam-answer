using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q63Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 175,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure Active Directory (Azure AD) tenant named contoso.onmicrosoft.com.",
                },
                new ContentEntity()
                {
                    Text = "The User administrator role is assigned to a user named Admin1.",
                },
                new ContentEntity()
                {
                    Text = "An external partner has a Microsoft account that uses the user1@outlook.com sign in.",
                },
                new ContentEntity()
                {
                    Text = "Admin1 attempts to invite the external partner to sign in to the Azure AD tenant and receives the following error message: “Unable to invite user.",
                },
                new ContentEntity()
                {
                    Text = "User1@outlook.com – Generic authorization exception.”.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that Admin1 can invite the external partner to sign in to the Azure AD tenant.",
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
                    Text = "From the Roles and administrators blade, assign the Security administrator role to Admin1.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From the Organizational relationships blade, add an identity provider.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From the Custom domain names blade, add a custom domain.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From the Users blade, modify the External collaboration settings.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "By default, all users and guests in your directory can invite guests even if they're not assigned to an admin role. External collaboration settings let you turn guest invitations on or off for different types of users in your organization. You can also delegate invitations to individual users by assigning roles that allow them to invite guests."
                },
                new ExplanationEntity()
                {
                    Text = "With Azure AD B2B collaboration, a tenant admin can set the following invitation policies:"
                },
                new ExplanationEntity()
                {
                    Text = "Turn off invitations"
                },
                new ExplanationEntity()
                {
                    Text = "Only admins and users in the Guest Inviter role can invite"
                },
                 new ExplanationEntity()
                {
                     Text = "Admins, the Guest Inviter role, and members can invite"
                },
                new ExplanationEntity()
                {
                    Text = "All users, including guests, can invite"
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Enable B2B external collaboration and manage who can invite guests",
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/b2b/delegate-invitations",
                },
            },
        };
    }
}