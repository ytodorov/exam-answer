using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q6Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 6,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an on-premises network that contains 100 servers.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a solution that provides additional resources to your users. The solution must minimize capital and operational expenditure costs.",
                },
                new ContentEntity()
                {
                    Text = "What should you include in the recommendation?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A complete migration to the public cloud.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An additional data center.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A private cloud.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A hybrid cloud.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Private cloud is a type of cloud computing that delivers similar advantages to public cloud, including scalability and self-service, but through a proprietary architecture. Unlike public clouds, which deliver services to multiple organizations, a private cloud is dedicated to the needs and goals of a single organization."
                },
                new ExplanationEntity()
                {
                    Text = "As a result, private cloud is best for businesses with dynamic or unpredictable computing needs that require direct control over their environments, typically to meet security, business governance or regulatory compliance requirements."
                },
                new ExplanationEntity()
                {
                    Text = "There are three general cloud deployment models: public, private and hybrid."
                },
                new ExplanationEntity()
                {
                    Text = "A public cloud is where an independent, third-party provider, such as Amazon Web Services (AWS) or Microsoft Azure, owns and maintains compute resources that customers can access over the internet. Public cloud users share these resources, a model known as a multi-tenant environment."
                },
                new ExplanationEntity()
                {
                    Text = "By comparison, a private cloud is created and maintained by an individual enterprise. The private cloud might be based on resources and infrastructure already present in an organization's on-premises data center or on new, separate infrastructure. In both cases, the enterprise itself owns and operates the private cloud."
                },
                new ExplanationEntity()
                {
                    Text ="A hybrid cloud is a model in which a private cloud connects with public cloud infrastructure, allowing an organization to orchestrate workloads across the two environments. In this model, the public cloud effectively becomes an extension of the private cloud to form a single, uniform cloud. A hybrid cloud deployment requires a high level of compatibility between the underlying software and services used by both the public and private clouds."
                },
                new ExplanationEntity()
                {
                    Text = "When an organization properly architects and implements a private cloud, it can provide most of the same benefits found in public clouds, such as user self-service and scalability, as well as the ability to provision and configure virtual machines (VMs) and change or optimize computing resources on demand. An organization can also implement chargeback tools to track computing usage and ensure business units pay only for the resources or services they use."
                },
                new ExplanationEntity()
                {
                    Text = "Private clouds are often deployed when public clouds are deemed inappropriate or inadequate for the needs of a business. For example, a public cloud might not provide the level of service availability or uptime that an organization needs. In other cases, the risk of hosting a mission-critical workload in the public cloud might exceed an organization's risk tolerance, or there might be security or regulatory concerns related to the use of a multi-tenant environment. In these cases, an enterprise might opt to invest in a private cloud to realize the benefits of cloud computing, while maintaining total control and ownership of its environment."
                },
                new ExplanationEntity()
                {
                    Text = "However, private clouds also have some disadvantages. First, private cloud technologies, such as increased automation and user self-service, can bring some complexity into an enterprise. These technologies typically require an IT team to rearchitect some of its data center infrastructure, as well as adopt additional management tools. As a result, an organization might have to adjust or even increase its IT staff to successfully implement a private cloud. This is different than public cloud, where most of the underlying complexity is handled by the cloud provider."
                },
                new ExplanationEntity()
                {
                    Text = "Another potential disadvantage of private clouds is cost. A benefit of public cloud is cost mitigation through the use of computing as a \"utility\" -- customers only pay for the resources they use. When a business owns its private cloud, however, it bears all of the acquisition, deployment, support and maintenance costs involved."
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "What is private cloud (internal cloud or corporate cloud)",
                    Url = "https://searchcloudcomputing.techtarget.com/definition/private-cloud"
                }
            },
        };
    }
}