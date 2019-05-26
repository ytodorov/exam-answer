using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q15Instance = new QuestionEntity()
        {
            Order = 15,
            QuestionType = QuestionType.CustomHtml,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company is performing an internal audit for reviewing the company's IT infrastructure, including the Azure infrastructure you manage.",
                },
                new ContentEntity()
                {
                    Text = "Your company also has an Office 365 subscription. The on-premises Active Directory Domain Services (AD DS) domain is synced with Azure Active Directory (Azure AD)."
                },
                new ContentEntity()
                {
                    Text = @"You need to provide auditors with administrator privileges. They need to be able to review users created in your Azure AD tenant. They should not be able to register applications in your Azure AD tenant."
                },
                new ContentEntity()
                {
                    Text = "Which four actions should you perform in sequence? To answer, move the appropriate actions from the list of possible actions to the answer area and arrange them in the correct order."
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = @"<div class=""demo-section hidden-on-narrow two-way wide"">
                <div class=""list-wrapper"">
                    <ul id=""sortable-listC"">
                        <li class=""list-item corect 1"">Create a Microsoft account for each auditor.</li>
                        <li class=""list-item corect 2"">Assign the owner role to each account.</li>
                        <li class=""list-item corect 3"">Add each auditor account as co-administrator.</li>
                        <li class=""list-item corect 4"">Assign the Directory Reader role to each account.</li>
                        <li class=""list-item"">Assign the contributors role to each account</li>
                        <li class=""list-item"">Assign the Company Administrator role to each account.</li>
                        <li class=""list-item"">Assign the Application Developer role to each account.</li>
                        <li class=""list-item"">Create an Office 365 user account for each auditor.</li>
                    </ul>
                </div>
            </div>
",
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You should perform the following actions in order:"
                },
                new ExplanationEntity()
                {
                    Text = @"1. Create a Microsoft account for each auditor.
2. Assign the owner role to each account.
3. Add each auditor account as co-administrator.
4. Assign the Directory Reader role to each account."
                },
                new ExplanationEntity()
                {
                    Text = "First, you need to create a Microsoft account for each auditor that needs to be granted with administrator privileges on the subscription. Using Microsoft accounts, you need to manage those users as guest users."
                },
                new ExplanationEntity()
                {
                    Text = "Next, you need to assign the owner role to each auditor's account. Only users with the owner role can be configured as subscription co-administrators."
                },
                new ExplanationEntity()
                {
                    Text = "Next, you need to assign the co-administrator role to each auditor's account."
                },
                new ExplanationEntity()
                {
                    Text = "Finally, you need to grant the Directory Reader role to each auditor's account. Because you use guest accounts, these users do not have the same permissions as an Azure AD Work or School account. Guest users with co-administrator privileges cannot access information from users or register applications in the Azure AD tenant. You need to manually grant the Directory Reader privileges to the auditor accounts."
                },
                new ExplanationEntity()
                {
                    Text = "You should not assign the contributor role. You can only assign the co-administrator role to subscription owners."
                },
                new ExplanationEntity()
                {
                    Text = "You should not create an Office 365 user account for each auditor. This type of account would grant the auditors more privileges than needed. When you grant co-administrator privileges to Azure AD Work or School accounts, you grant all privileges to these users, including read permission over other users or the ability to create new applications in the Azure AD tenant."
                },
                new ExplanationEntity()
                {
                    Text = "You should not grant the Application Developer role. This role allows the user to create new applications in the Azure AD tenant. This goes against required privileges mentioned in the scenario."
                },
                new ExplanationEntity()
                {
                    Text = "You should not grant the Company Administrator role. This role allows you to manage the Azure AD tenant globally, including the ability to add new applications to the tenant."
                },
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "Add or change Azure subscription administrators",
                     Url = "https://docs.microsoft.com/en-us/azure/billing/billing-add-change-azure-subscription-administrator",
                },
                new ReferenceEntity()
                {
                     Text = "Administrator role permissions in Azure Active Directory",
                     Url = "https://docs.microsoft.com/en-us/azure/active-directory/users-groups-roles/directory-assign-admin-roles",
                },
                new ReferenceEntity()
                {
                     Text = "Built-in roles for Azure resources",
                     Url = "https://docs.microsoft.com/en-us/azure/role-based-access-control/built-in-roles",
                },
            }
        };
    }
}