using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q4Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 6,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You plan to migrate a web application to Azure. The web application is accessed by external users.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a cloud deployment solution to minimize the amount of administrative effort used to manage the web application.",
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
                    Text = "Software as a service (SaaS).",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Platform as a service (PaaS).",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Infrastructure as a service (IaaS).",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Database as a service (DaaS).",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "IaaS (Information as a Service). IaaS is the most basic level of cloud-based solutions, which refers to renting an IT infrastructure as a fully outsourced service. In this category, the cloud provider lets you rent servers, VMs, storage, network and operating systems on a pay-as-you-go basis."
                },
                new ExplanationEntity()
                {
                    Text = "Examples: Amazon EC2 and S3, Google Compute Engine, Windows Azure."
                },
                new ExplanationEntity()
                {
                    Text = "PaaS (Platform as a Service). PaaS is the cloud solution where, apart from providing an infrastructure, cloud providers also issue an on-demand computing environment to develop, test, run and collaborate with components such as web servers, database management systems, and software development kits (SDKs) for various programming languages."
                },
                new ExplanationEntity()
                {
                    Text = "Examples: AWS Elastic Beanstalk, Heroku, Windows Azure, Force.com, Google App Engine."
                },
                new ExplanationEntity()
                {
                    Text = "SaaS (Software as a Service). SaaS providers offer fully functional web-based application softwares tailored to a variety of business needs such as project tracking, web conferencing, marketing automation or business analytics."
                },
                new ExplanationEntity()
                {
                    Text = "Examples: Google Apps, Microsoft Office 365, Gmail, Yahoo and Facebook."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Windows Azure IaaS vs. PaaS vs. SaaS",
                    Url = "http://robertgreiner.com/2014/03/windows-azure-iaas-paas-saas-overview/"
                }
            },
        };
    }
}