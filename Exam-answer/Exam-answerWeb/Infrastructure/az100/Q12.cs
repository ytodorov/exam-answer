using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q12Instance = new QuestionEntity()
        {
            Order = 12,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You determine that business units have Azure resources spread across different Azure resource groups.",
                },
                new ContentEntity()
                {
                    Text = "You need to make sure that resources are assigned to their proper cost centers."
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
                    Text = "Create taxonomic tags and assign them at the resource level.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create taxonomic tags and assign them at the resource group level.",
                },
                new AnswerEntity()
                {
                    Text = "Deploy the Enforce tag and its value on resource groups Azure Policy.",
                },
                new AnswerEntity()
                {
                    Text = "Deploy the Enforce tag and its value Azure Policy.",
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You should create taxonomic tags and assign them at the resource level. Tags in Azure are key-value string pairs that administrators can associate with Azure resources for logical organization. Identifying cost centers is an excellent use case for tags. Because corporate divisions own Azure resources spread across different Azure resource groups, you have to assign cost center tags at the resource level. Wherever possible, it is best practice to organize related resources into the same resource groups because you can then bulk-assign taxonomic tags to all contained resources in a single operation."
                },
                new ExplanationEntity()
                {
                    Text = "You should not create taxonomic tags and assign them at the resource group level. The scenario states that business units have resources spread across different resource groups. If you assign a particular cost center tag at the resource group level, then you likely will mis-tag contained resources owned by another business unit."
                },
                new ExplanationEntity()
                {
                    Text = "You should not deploy the Enforce tag and its value Azure Policy. Doing so enforces the presence of a single specified tag and value pair. In this case, the scenario states that the organization has more than one cost center and therefore needs more than one taxonomic tag."
                },
                new ExplanationEntity()
                {
                    Text = "You should not deploy the Enforce tag and its value on resource groups Azure Policy for the same reasons. The company has more than one cost center, and the business units have resources spread across multiple resource groups."
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
                     Text = "Prevent unexpected charges with Azure billing and cost management",
                     Url = "https://docs.microsoft.com/en-us/azure/billing/billing-getting-started",
                },
                new ReferenceEntity()
                {
                     Text = "What is Azure Policy?",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-policy/azure-policy-introduction",
                },
                new ReferenceEntity()
                {
                     Text = "Create and manage policies to enforce compliance",
                     Url = "https://docs.microsoft.com/en-us/azure/azure-policy/create-manage-policy",
                },
            }
        };
    }
}