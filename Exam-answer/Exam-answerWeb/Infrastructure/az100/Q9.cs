using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q9Instance = new QuestionEntity()
        {
            Order = 9,
            QuestionType = QuestionType.CustomHtml,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure resource group named RG1. RG1 contains 12 virtual machines (VMs) that run Windows Server or Linux.",
                },
                new ContentEntity()
                {
                    Text = "You need to use Azure Cloud Shell to lift any resource locks that were applied to the VMs."
                },
                new ContentEntity()
                {
                    Text = "How should you complete the Azure PowerShell command? To answer, select the appropriate options from the drop-down menus."
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = @"<select class=""ea"">
                    <option></option>
                    <option selected=""selected"">Get-AzureRmResourceLock</option>
                    <option>Get-AzureRmResource</option>
                </select>
                &nbsp;| &nbsp;
                <select class=""ea"">
                    <option></option>
                    <option>Select-Object</option>
                    <option selected=""selected"">Where-Object</option>
                </select>
                &nbsp; ResourceGroupName -eq ""$rg-name"" | &nbsp;
                <select class=""ea"">
                    <option></option>
                    <option>Remove-AzureRmResource</option>
                    <option selected=""selected"">Remove-AzureRmResourceLock</option>
                </select>",
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
                    Text = @"$rg = ""rg1""
Get-AzureRmResourceLock |
Where-Object ResourceGroupName -eq ""$rg-name"" |
Remove-AzureRmResourceLock -Force"
                },
                new ExplanationEntity()
                {
                    Text = "To programmatically lift resource locks in Azure, start with the Get-AzureRmResourceLock command to retrieve all resource locks in your current subscription context. You can add a Where-Object filter expression to retrieve only locks from a particular resource group."
                },
                new ExplanationEntity()
                {
                    Text = "Next, you can take advantage of the PowerShell pipeline by piping your results to the Remove-AzureRmResourceLock cmdlet to actually remove the locks. The -Force switch parameter forces the command to run without asking for user confirmation."
                },
                 new ExplanationEntity()
                {
                    Text = "You should not use the Get-AzureRmResource or Remove-AzureRmResource cmdlets because doing so requires far more PowerShell code than is shown in the scenario to retrieve only locked resources from a specific resource group."
                },
                  new ExplanationEntity()
                {
                    Text = "You should not use the Select-Object cmdlet because it filters at the property level, and not the row level, and would therefore not restrict output to locked resources within a single resource group."
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
                     Text = "Get-AzureRmResourceLock",
                     Url = "https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/get-azurermresourcelock",
                },
                new ReferenceEntity()
                {
                     Text = "Get-AzureRmResource",
                     Url = "https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/get-azurermresource",
                },
                new ReferenceEntity()
                {
                     Text = "Where-Object",
                     Url = "https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.core/where-object",
                },
                new ReferenceEntity()
                {
                     Text = "Select-Object",
                     Url = "https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/select-object",
                },
                new ReferenceEntity()
                {
                     Text = "Remove-AzureRmResourceLock",
                     Url = "https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/remove-azurermresourcelock",
                },
                 new ReferenceEntity()
                {
                     Text = "Remove-AzureRmResource",
                     Url = "https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/remove-azurermresource",
                },
            }
        };
    }
}