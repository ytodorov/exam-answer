
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q86Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 216,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Subscription1 that is used by several departments at your company. Subscription1 contains the resources in the following.",
                },
                new ContentEntity()
                {
                    Text = "Table.",
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
                    Text = "VM1.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Storage2.", 
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
                    Text = "3. The portal displays a summary of the deployment. The summary includes the status of the deployment and its operations and the values that you provided for"
                },
                new ExplanationEntity()
                {
                    Text = "parameters. To see the template that you used for the deployment, select View template."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-manager-export-template",
                },
            },           
        };
    }
}
