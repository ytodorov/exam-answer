
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q110Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 246,
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
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://techcommunity.microsoft.com/t5/Azure-Active-Directory/Generic-authorization-exception-inviting-Azure-AD-gests/td-p/274742",
                },
            },           
        };
    }
}
