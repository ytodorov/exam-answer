
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q42Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 53,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You attempt to create several managed Microsoft SQL Server instances in an Azure environment and receive a message that you must increase your Azure.",
                },
                new ContentEntity()
                {
                    Text = "Subscription limits.",
                },
                new ContentEntity()
                {
                    Text = "What should you do to increase the limits?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a service health alert.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Upgrade your support plan.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Modify an Azure policy.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create a new support request.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "If you want to raise the limit or quota above the default limit, open an online customer support request at no charge. The limits can't be raised above the maximum limit value shown in the following tables. If there's no maximum limit column, the resource doesn't have adjustable limits."
                },
                new ExplanationEntity()
                {
                    Text = "Free Trial subscriptions aren't eligible for limit or quota increases. If you have a Free Trial subscription, you can upgrade to a Pay-As-You-Go subscription. For more information, see Upgrade your Azure Free Trial subscription to a Pay-As-You-Go subscription and the Free Trial subscription FAQ."
                },
                new ExplanationEntity()
                {
                    Text  = "Quotas for resources in Azure resource groups are per-region accessible by your subscription, not per-subscription as the service management quotas are. Let's use vCPU quotas as an example. To request a quota increase with support for vCPUs, you must decide how many vCPUs you want to use in which regions. You then make a specific request for Azure resource group vCPU quotas for the amounts and regions that you want. If you need to use 30 vCPUs in West Europe to run your application there, you specifically request 30 vCPUs in West Europe. Your vCPU quota isn't increased in any other region--only West Europe has the 30-vCPU quota."
                },
                new ExplanationEntity()
                {
                    Text = "As a result, decide what your Azure resource group quotas must be for your workload in any one region. Then request that amount in each region into which you want to deploy. For help in how to determine your current quotas for specific regions, see Troubleshoot deployment issues."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Azure subscription and service limits, quotas, and constraints",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-subscription-service-limits"
                },
            },                
        };
    }
}
