
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q105Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 208,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure Active Directory (Azure AD) tenant named contoso.onmicrosoft.com.",
                },
                new ContentEntity()
                {
                    Text = "You hire a temporary vendor. The vendor uses a Microsoft account that has a sign-in of user1@outlook.com.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that the vendor can authenticate to the tenant by using user1@outlook.com.",
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
                    Text = "From the Azure portal, add a custom domain name, create a new Azure AD user, and then specify user1@outlook.com as the username.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From Azure Cloud Shell, run the New-AzureADUser cmdlet and specify the \"–UserPrincipalName user1@outlook.com\" parameter.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From the Azure portal, add a new guest user, and then specify user1@outlook.com as the email address.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From Windows PowerShell, run the New-AzureADUser cmdlet and specify the \"–UserPrincipalName user1@outlook.com\" parameter.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "UserPrincipalName - contains the UserPrincipalName (UPN) of this user. The UPN is what the user will use when they sign in into Azure AD. The common structure is @, so for Abby Brown in Contoso.com, the UPN would be AbbyB@contoso.com"
                },
                new ExplanationEntity()
                {
                    Text = "To create the user, call the New-AzureADUser cmdlet with the parameter values:"
                },
                new ExplanationEntity()
                {
                    Text = "powershell New-AzureADUser -AccountEnabled $True -DisplayName \"Abby Brown\" -PasswordProfile $PasswordProfile -MailNickName \"AbbyB\" - UserPrincipalName \"AbbyB@contoso.com\""
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Creating a new user in Azure AD",
                    Url = "https://docs.microsoft.com/bs-cyrl-ba/powershell/azure/active-directory/new-user-sample?view=azureadps-2.0",
                },
            },
        };
    }
}