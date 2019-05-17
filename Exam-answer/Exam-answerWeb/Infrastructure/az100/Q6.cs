using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q6Instance = new QuestionEntity()
        {
            Order = 6,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You manage a Windows Server virtual machine (VM) in Azure named prod-vm1. The VM uses managed disk storage, runs Windows Server 2012 R2, and resides in a resource group named prod-west-rg located in the West US region.",
                },
                new ContentEntity()
                {
                    Text = "You need to move prod-vm1 to a resource group named prod-east located in the East US region."
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
                    Text = "Back up prod-vm1 and restore the VM to the prod-east-rg resource group. Delete the original VM instance.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Author an Azure Resource Manager (ARM) template that moves prod-vm1 to the prod-east-rg resource group.",
                },
                new AnswerEntity()
                {
                    Text = "Move prod-vm1 to the prod-east-rg resource group by using the Move-AzureRmResource PowerShell cmdlet.",
                },
                new AnswerEntity()
                {
                    Text = "Use azcopy to copy prod-vm1 to the prod-east-rg resource group.",
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You should back up prod-vm1, restore the VM to the prod-east-rg resource group, and then delete the original VM instance. Unfortunately, managed disks are one of the few Azure resources that cannot be moved between resource groups or subscriptions. Because the VM in Azure has so many dependencies, this managed disk restriction means that you are unable to move the entire VM without redeploying the disks and configuration into the new resource group."
                },
                new ExplanationEntity()
                {
                    Text = "You cannot move prod-vm1 to the prod-east-rg resource group by using the Move-AzureRmResource PowerShell cmdlet because the scenario states that the VM uses managed disk storage. If the VM used unmanaged disk storage, the Move-AzureRmResource command could move the VM to another resource group or even another Azure subscription."
                },
                new ExplanationEntity()
                {
                    Text = "You cannot use azcopy to copy prod-vm1 to the prod-east-rg resource group. Azcopy is a cross-platform command-line tool with which you can copy or move binary large object (BLOB) data between storage accounts. In this case, the VM in question uses managed disk storage. Moreover, Azcopy cannot migrate VM configuration, only virtual hard disks (VHDs)."
                },
                new ExplanationEntity()
                {
                    Text = "You cannot author an Azure Resource Manager (ARM) template that moves prod-vm1 to the prod-east-rg resource group because it uses managed disk storage."
                }
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "Move resources to new resource group or subscription",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-move-resources",
                },
                new ReferenceEntity()
                {
                     Text = "Frequently asked questions about Azure IaaS VM disks and managed and unmanaged premium disks",
                     Url = "https://docs.microsoft.com/en-us/azure/virtual-machines/windows/faq-for-disks",
                },
                new ReferenceEntity()
                {
                     Text = "Transfer data with the AzCopy on Windows",
                     Url = "https://docs.microsoft.com/en-us/azure/storage/common/storage-use-azcopy",
                },
                new ReferenceEntity()
                {
                     Text = "Download the template for a VM",
                     Url = "https://docs.microsoft.com/en-us/azure/virtual-machines/windows/download-template",
                },
                new ReferenceEntity()
                {
                     Text = "Move-AzureRmResource",
                     Url = "https://docs.microsoft.com/en-us/powershell/module/azurerm.resources/move-azurermresource",
                },
            }
        };
    }
}