using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q8Instance = new QuestionEntity()
        {
            Order = 8,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You deploy a Storage Account named store01 in your Azure subscription.",
                },
                new ContentEntity()
                {
                    Text = "You grant the contributor role to some users in store01. The users work on an application that will use the storage account for storing some information."
                },
                new ContentEntity()
                {
                    Text = "The users report that they are not able to list the storage account keys for connecting their application to the storage account."
                },
                 new ContentEntity()
                {
                    Text = "You need to identify the root cause of the issue."
                },
                  new ContentEntity()
                {
                    Text = "What is the most probable cause?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "You need to grant the users the owner role.",
                },
                new AnswerEntity()
                {
                    Text = "You configured a ReadOnly lock.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "You configured a CanNotDelete lock.",
                },
                new AnswerEntity()
                {
                    Text = "You need to grant the users the Storage Account Key Operator Service role.",
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "The reason that the users are not able to list the storage account keys is that you configured a ReadOnly lock. Locks are applied to any operation that makes a request to the following URL: https://management.azure.com. When you apply a ReadOnly lock, you can unintentionally block access to other resources. In this case, you are blocking access to the keys because the list operation is handled through POST operations and the returned keys will be used for write operations."
                },
                new ExplanationEntity()
                {
                    Text = "Configuring a CanNotDelete lock does not affect the list keys operation. The CanNotDelete lock prevents a user from deleting a resource but still allows users to modify and read resources in the resource group."
                },
                new ExplanationEntity()
                {
                    Text = "You do not need to grant your users with Owner or Storage Account Key Operator Service roles. When you configure a lock in a resource or resource group, this takes precedence over any assigned role, even the Owner role. If you want to remove the lock, you need to have access to the Microsoft.Authorization/* or Microsoft.Authorization/locks/* actions. Only the Owner and User Access Administrator roles have enough privileges to manage locks. In this scenario, granting the Owner role to your users will enable them to remove the ReadOnly lock on their own."
                },
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "Lock resources to prevent unexpected changes",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-lock-resources",
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