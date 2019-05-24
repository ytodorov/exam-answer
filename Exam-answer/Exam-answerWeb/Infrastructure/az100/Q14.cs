using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q14Instance = new QuestionEntity()
        {
            Order = 14,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You use taxonomic tags to logically organize resources and to make billing reporting easier.",
                },
                new ContentEntity()
                {
                    Text = "You use Azure PowerShell to append an additional tag on a storage account named corpstorage99. The code is as follows:"
                },
                new ContentEntity()
                {
                    Text = @"$r = Get-AzureRmResource -ResourceName ""corpstorage99"" -ResourceGroupName ""prod-rg""
Set-AzureRmResource -Tag @{Dept=""IT""} -ResourceId $r.ResourceId -Force"
                },
                new ContentEntity()
                {
                    Text = "The code returns unexpected results."
                },
                 new ContentEntity()
                {
                    Text = "You need to append the additional tag as quickly as possible."
                },
                  new ContentEntity()
                {
                    Text = "What should you do?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Refactor the code by using the Azure Command-Line Interface (CLI).",                    
                },
                new AnswerEntity()
                {
                    Text = "Call the Add() method on the resource to append the new tag.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Deploy the tag by using an Azure Resource Manager template.",                   
                },
                new AnswerEntity()
                {
                    Text = "Assign the Enforce tag and its value Azure Policy to the resource group.",
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You should call the Add() method on the storage account resource as shown in the second line of this refactored Azure PowerShell code: "
                },
                new ExplanationEntity()
                {
                    Text = @"$r = Get-AzureRmResource -ResourceName ""corpstorage99"" -ResourceGroupName ""prod-rg""
$r.Tags.Add(""Dept"", ""IT"")
Set-AzureRmResource -Tag $r.Tags -ResourceId $r.ResourceId -Force "
                },
                new ExplanationEntity()
                {
                    Text = "Unless you call the Add() method, the Set-AzureRmResource cmdlet will overwrite any existing taxonomic tags on the resource. The Add() method preserves existing tags and includes one or more tags to the resource tag list."
                },
                new ExplanationEntity()
                {
                    Text = "You should not deploy the tag by using an Azure Resource Manager template. Doing so is unnecessary in this case because the Azure PowerShell is mostly complete as-is. Furthermore, you must find the solution as quickly as possible."
                },
                new ExplanationEntity()
                {
                    Text = "You should not assign the Enforce tag and its value Azure Policy to the resource group. Azure Policy is a governance feature that helps businesses enforce compliance in resource creation. In this case, the solution involves too much administrative overhead to be a viable option. Moreover, the scenario makes no mention of the need for governance policy in specific terms."
                },
                new ExplanationEntity()
                {
                    Text = "You should not refactor the code by using the Azure Command-Line Interface (CLI). Either Azure PowerShell or Azure CLI can be used to institute this solution. It makes no sense to change the development language given that you have already completed most of the code in PowerShell."
                }
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "Use tags to organize your Azure resources",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-using-tags",
                },
                new ReferenceEntity()
                {
                     Text = "Set-AzureRmResource",
                     Url = "https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/set-azurermresource",
                },
                new ReferenceEntity()
                {
                     Text = "What is Azure Policy?",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-policy/azure-policy-introduction",
                },
                new ReferenceEntity()
                {
                     Text = "Azure CLI",
                     Url = "https://docs.microsoft.com/en-us/cli/azure/",
                },
                   new ReferenceEntity()
                {
                     Text = "Quickstart: Create and deploy Azure Resource Manager templates by using the Azure portal",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-manager-quickstart-create-templates-use-the-portal",
                },
            }
        };
    }
}