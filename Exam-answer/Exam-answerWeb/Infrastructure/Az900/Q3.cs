
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q2Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 3,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {              
                new ContentEntity()
                {
                    Text = "Your company plans to migrate all its data and resources to Azure.",
                },
                new ContentEntity()
                {
                    Text = "The company’s migration plan states that only platform as a service (PaaS) solutions must be used in Azure.",
                },
                new ContentEntity()
                {
                    Text = "You need to deploy an Azure environment that supports the planned migration.",
                },
                new ContentEntity()
                {
                    Text = "Solution: You create an Azure App Service and Azure SQL databases.",
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "No.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Platform as a service (PaaS) is a complete development and deployment environment in the cloud, with resources that enable you to deliver everything from simple cloud-based apps to sophisticated, cloud-enabled enterprise applications. You purchase the resources you need from a cloud service provider on a pay-as-you-go basis and access them over a secure Internet connection."
                },
                new ExplanationEntity()
                {
                    Text = "Like IaaS, PaaS includes infrastructure—servers, storage and networking—but also middleware, development tools, business intelligence (BI) services, database management systems and more. PaaS is designed to support the complete web application lifecycle: building, testing, deploying, managing and updating."
                },
                new ExplanationEntity()
                {
                    Text = "PaaS allows you to avoid the expense and complexity of buying and managing software licenses, the underlying application infrastructure and middleware, container orchestrators such as Kubernetes or the development tools and other resources. You manage the applications and services you develop and the cloud service provider typically manages everything else."
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "",
                    Url = "https://azure.microsoft.com/en-in/overview/what-is-paas/"
                }
            },           
        };
    }
}
