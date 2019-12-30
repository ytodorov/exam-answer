using DAL.Entities;
using System.Collections.Generic;
using Exam_answerWeb.Extensions;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q87Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 87,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Subscription1 that is used by several departments at your company. Subscription1 contains the resources in the following table:",
                },
                new ContentEntity()
                {
                    Text = "***",
                },
                new ContentEntity()
                {
                    Text = "Name: Storage1,".PadRightEA() + "Type: Storage account",
                },
                new ContentEntity()
                {
                    Text = "Name: RG1,".PadRightEA() + "Type: Resource group",
                },
                new ContentEntity()
                {
                    Text = "Name: Container1,".PadRightEA() + "Type: Blob container",
                },
                new ContentEntity()
                {
                    Text = "Name: Share1,".PadRightEA() + "Type: File share",
                },
                new ContentEntity()
                {
                    Text = "***",
                },
                new ContentEntity()
                {
                    Text = "Another administrator deploys a virtual machine named VM1 and an Azure Storage account named Storage2 by using a single Azure Resource Manager template.",
                },
                new ContentEntity()
                {
                    Text = "You need to view the template used for the deployment.",
                },
                new ContentEntity()
                {
                    Text = "From which blade can you view the template that was used for the deployment?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Container1.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "RG1.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Share1.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Storage1.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "View template from deployment history"
                },
                new ExplanationEntity()
                {
                    Text = "1. Go to the resource group for your new resource group. Notice that the portal shows the result of the last deployment. Select this link."
                },
                new ExplanationEntity()
                {
                    Text = "2. You see a history of deployments for the group. In your case, the portal probably lists only one deployment. Select this deployment."
                },
                new ExplanationEntity()
                {
                    Text = "3. The portal displays a summary of the deployment. The summary includes the status of the deployment and its operations and the values that you provided for parameters. To see the template that you used for the deployment, select View template."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Manage Azure resources by using the Azure portal",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-manager-export-template",
                },
            },
        };
    }
}