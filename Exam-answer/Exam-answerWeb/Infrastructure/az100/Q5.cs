using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q5Instance = new QuestionEntity()
        {
            Order = 5,
            QuestionType = QuestionType.CustomHtml,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You use the Azure Command-line Interface (CLI) to manage the company's subscription.",
                },
                new ContentEntity()
                {
                    Text = "You need to assign taxonomic tags to a new resource group named prod-rg."
                },
                new ContentEntity()
                {
                    Text = "How should you complete the Azure CLI command?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = $@"<select class=""ea"">
                    <option></option>
                    <option class=""correct"">az group update</option>
                    <option>az policy assignment</option>
                    <option>az resource tag</option>
                    <option>az tag add-value</option>
                    <option>name prod-rg</option>
                </select>
                &nbsp;--
                <select class=""ea"">
                    <option></option>
                    <option>az group update</option>
                    <option>az policy assignment</option>
                    <option>az resource tag</option>
                    <option>az tag add-value</option>
                    <option class=""correct"">name prod-rg</option>
                </select>
                &nbsp;--set tags.Dept=IT",
                    IsCorrect = true
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You should run az group update to assign taxonomic tags to an Azure resource group like so:"
                },
                new ExplanationEntity()
                {
                    Text = "az group update --name prod-rg --set tags.Dept=IT"
                },
                new ExplanationEntity()
                {
                    Text = "Note that this command overwrites any existing tags on the resource group. In that case, you would need to edit your Azure CLI code to retrieve the existing tags, reformat that value, and then reapply the existing and new tags."
                },
                new ExplanationEntity()
                {
                    Text = "You should not run the az resource tag command. This command applies tags at the individual resource level, but not the resource group level."
                },
                new ExplanationEntity()
                {
                    Text = "You should not run the az policy assignment command. This command assigns an Azure Policy to a management group or resource group."
                },
                new ExplanationEntity()
                {
                    Text = "You should not run the az tag add-value command. This command edits the value of a previously created Azure taxonomic tag."
                },
            },
            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                     Text = "Azure CLI",
                     Url = "https://docs.microsoft.com/en-us/cli/azure/",
                },
                new ReferenceEntity()
                {
                     Text = "Use tags to organize your Azure resources",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-using-tags",
                },
                new ReferenceEntity()
                {
                     Text = "Use the Azure CLI to manage Azure resources and resource groups",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/xplat-cli-azure-resource-manager",
                },
            }
        };
    }
}