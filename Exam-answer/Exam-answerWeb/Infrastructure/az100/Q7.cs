using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q7Instance = new QuestionEntity()
        {
            Order = 7,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You deploy an application in a resource group named App-RG01 in your Azure subscription.",
                },
                new ContentEntity()
                {
                    Text = "App-RG01 contains the following components:"
                },
                new ContentEntity()
                {
                    Text = @"* Two App Services, each with an SSL certificate
* A peered virtual network (VNet)
* Redis cache deployed in the VNet
* Standard Load Balancer"
                },
                 new ContentEntity()
                {
                    Text = "You need to move all resources in App-RG01 to a new resource group named App-RG02."
                },
                  new ContentEntity()
                {
                    Text = "Choose all that apply:"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "You need to delete SSL certificate from each App Service before moving it to the new resource group.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "You can move the Load Balancer only within the same subscription.",
                },
                new AnswerEntity()
                {
                    Text = "You need to disable the peer before moving the VNet.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "You can move the VNet only within the same subscription.",
                    IsCorrect = true
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You should create a tag named CostCenter and assign it to each resource group. Creating a tag and assigning it to each resource group allows you to easily identify the cost center associated with each resource group. When you associate a tag with a resource or resource group, you need to provide a value to that tag. You can instruct the accounting department to use the Azure Cost Management tool to review the costs associated with each cost center by filtering by the newly created tag."
                },
                new ExplanationEntity()
                {
                    Text = "You should also create a tag named CostCenter and assign it to each resource. If you apply a tag to a resource group, that tag is not inherited by the resources in the resource group. You need to manually configure the tag for each resource that you want to include in the cost center. You can automate this action by using a PowerShell or Azure CLI script."
                },
                new ExplanationEntity()
                {
                    Text = "You should not instruct the accounting department to use either the Cost Analysis blade in the subscription panel or the Azure Account Center. Because your subscription is managed by a Cloud Service Provider, you can get that information from your provider. You can also get this information by using the Azure Cost Management tool."
                },
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "Move resources to new resource group or subscription",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-move-resources",
                },
            }
        };
    }
}