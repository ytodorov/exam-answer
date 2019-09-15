using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q68Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 190,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure Active Directory (Azure AD) tenant named Adatum and an Azure Subscription named Subscription1. Adatum contains a group named Developers.",
                },
                new ContentEntity()
                {
                    Text = "Subscription1 contains a resource group named Dev.",
                },
                new ContentEntity()
                {
                    Text = "You need to provide the Developers group with the ability to create Azure logic apps in the Dev resource group.",
                },
                new ContentEntity()
                {
                    Text = "Solution: On Dev, you assign the Logic App Contributor role to the Developers group.",
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
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "No.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You can permit only specific users or groups to run specific operations, such as managing, editing, and viewing logic apps. To control their permissions, use Azure Role-Based Access Control (RBAC) to assign customized or built-in roles to members in your Azure subscription:"
                },
                new ExplanationEntity()
                {
                    Text = "Logic App Contributor: Lets you manage logic apps, but you can't change access to them."
                },
                new ExplanationEntity()
                {
                    Text = "Logic App Operator: Lets you read, enable, and disable logic apps, but you can't edit or update them."
                },
                new ExplanationEntity()
                {
                    Text = "To prevent others from changing or deleting your logic app, you can use Azure Resource Lock, which prevents others from changing or deleting production resources."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Built-in roles for Azure resources",
                    Url = "https://docs.microsoft.com/en-us/azure/role-based-access-control/built-in-roles",
                },
                new ReferenceEntity()
                {
                    Text = "Secure access and data in Azure Logic Apps",
                    Url = "https://docs.microsoft.com/en-us/azure/logic-apps/logic-apps-securing-a-logic-app",
                },
            },
        };
    }
}