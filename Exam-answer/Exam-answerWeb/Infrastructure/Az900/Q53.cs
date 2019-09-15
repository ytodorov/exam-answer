using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q52Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 92,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "Azure Germany can be used by *** LEGAL RESIDENTS OF GERMANY ONLY ***.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the UPPER-CASED text surrounded by ***. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Only enterprises that are registered in Germany.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Only enterprises that purchase their azure licenses from a partner based in Germany.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Any user or enterprise that requires its data to reside in Germany.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Microsoft Azure Germany delivers a cloud platform built on the foundational principles of security, privacy, compliance, and transparency. Azure Germany is a physically isolated instance of Microsoft Azure. It uses world-class security and compliance services that are critical to German data privacy regulations for all systems and applications built on its architecture. Operated by a data trustee, Azure Germany supports multiple hybrid scenarios for building and deploying solutions on-premises or in the cloud. You can also take advantage of the instant scalability and guaranteed uptime of a hyperscale cloud service."
                },
                new ExplanationEntity()
                {
                    Text = "Azure Germany includes the core components of infrastructure as a service (IaaS), platform as a service (PaaS), and software as a service (SaaS). These components include infrastructure, network, storage, data management, identity management, and many other services."
                },
                new ExplanationEntity()
                {
                    Text = "Azure Germany supports most of the same great features that global Azure customers have used, like geosynchronous data replication and autoscaling."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Welcome to Azure Germany",
                    Url = "https://docs.microsoft.com/en-us/azure/germany/germany-welcome",
                },
            },
        };
    }
}