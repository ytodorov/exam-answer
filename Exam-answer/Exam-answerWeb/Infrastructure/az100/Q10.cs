using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q10Instance = new QuestionEntity()
        {
            Order = 10,
            QuestionType = QuestionType.CustomHtml,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure resource group named RG1. RG1 contains six virtual machines (VMs) that run Windows Server or Linux.",
                },
                new ContentEntity()
                {
                    Text = "You plan to use Azure Cloud Shell to add a new tag with the name of Status and value of Approved to all VMs contained in RG1. You need to ensure that all existing tags are preserved."
                },
                new ContentEntity()
                {
                    Text = "How should you complete the Azure PowerShell command? To answer, select the appropriate options from the drop-down menus. "
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = @"$tags = (Get-AzureRmResourceGroup -Name RG1).Tags
                <br />
                <select class=""ea"">
                    <option></option>
                    <option selected=""selected"">$tags.Add</option>
                    <option>$tags | Add</option>
                </select>
                &nbsp;(""Status"", ""Approved"") &nbsp;
                <select class=""ea"">
                    <option></option>
                    <option>Set-AzureRmResourceGroup</option>
                    <option selected=""selected"">Set-AzureRmResource</option>
                </select>
                &nbsp; -Tag $tags -Name &nbsp;
                <select class=""ea"">
                    <option></option>
                    <option>RG1</option>
                    <option selected=""selected"">$tags</option>
                </select>
",
                },               
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You should use the following command:"
                },
                new ExplanationEntity()
                {
                    Text = @"$tags = (Get-AzureRmResourceGroup -Name RG1).Tags
$tags.Add(""Status"", ""Approved"")
Set-AzureRmResourceGroup -Tag $tags -Name RG1"
                },
                new ExplanationEntity()
                {
                    Text = "You should access the Add() method of your $tags object to add a new tag to the target resource group. You should not use the pipe (|) character because in PowerShell you use the dot (.) and not the pipe to access object members such as properties, methods, or events."
                },
                new ExplanationEntity()
                {
                    Text = "You should use the Set-AzureRmResourceGroup cmdlet to modify a resource group. You should not use the Set-AzureRmResource cmdlet because doing so requires far more code than what is provided to accomplish the goal."
                },
                 new ExplanationEntity()
                {
                    Text = "You should specify RG1 for the -Name property of the Set-AzureRmResourceGroup cmdlet because this parameter requires a string value that matches the name of the target resource group. You should not use the $tags variable because this is an object storing the resource group's current tag list."
                },
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
                     Text = "Set-AzureRmResourceGroup",
                     Url = "https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/set-azurermresourcegroup",
                },
                new ReferenceEntity()
                {
                     Text = "Get-AzureRmResource",
                     Url = "https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/get-azurermresource",
                },
            }
        };
    }
}