
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q58Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 157,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have two Azure Active Directory (Azure AD) tenants named contoso.com and fabrikam.com.",
                },
                new ContentEntity()
                {
                    Text = "You have a Microsoft account that you use to sign in to both tenants.",
                },
                new ContentEntity()
                {
                    Text = "You need to configure the default sign-in tenant for the Azure portal.",
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
                    Text = "From Azure Cloud Shell, run Set-AzureRmSubscription.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From Azure Cloud Shell, run Set-AzureRmContext.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "From the Azure portal, configure the portal settings.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From the Azure portal, change the directory.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "The Set-AzureRmContext cmdlet sets authentication information for cmdlets that you run in the current session. The context includes tenant, subscription, and environment information."
                },
                new ExplanationEntity()
                {
                    Text = "Example: PS C:\\>Set-AzureRmContext -SubscriptionId \"xxxx-xxxx-xxxx-xxxx\""
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Set-AzureRmContext",
                    Url = "https://docs.microsoft.com/en-us/powershell/module/azurerm.profile/set-azurermcontext?view=azurermps-6.13.0",
                },
            },
        };
    }
}
