using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q49Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 49,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You need to identify the type of failure for which an Azure availability zone can be used to protect access to Azure services.",
                },
                new ContentEntity()
                {
                    Text = "What should you identify?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A physical server failure.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure region failure.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A storage failure.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure data center failure.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Availability Zones is a high-availability offering that protects your applications and data from datacenter failures. Availability Zones are unique physical locations within an Azure region. Each zone is made up of one or more datacenters equipped with independent power, cooling, and networking. To ensure resiliency, there’s a minimum of three separate zones in all enabled regions. The physical separation of Availability Zones within a region protects applications and data from datacenter failures. Zone-redundant services replicate your applications and data across Availability Zones to protect from single-points-of-failure. With Availability Zones, Azure offers industry best 99.99% VM uptime SLA. The full Azure SLA explains the guaranteed availability of Azure as a whole."
                },
                new ExplanationEntity()
                {
                    Text = "An Availability Zone in an Azure region is a combination of a fault domain and an update domain. For example, if you create three or more VMs across three zones in an Azure region, your VMs are effectively distributed across three fault domains and three update domains. The Azure platform recognizes this distribution across update domains to make sure that VMs in different zones are not updated at the same time."
                },
                new ExplanationEntity()
                {
                    Text = "Build high-availability into your application architecture by co-locating your compute, storage, networking, and data resources within a zone and replicating in other zones. Azure services that support Availability Zones fall into two categories:"
                },
                new ExplanationEntity()
                {
                    Text = "Zonal services – you pin the resource to a specific zone (for example, virtual machines, managed disks, Standard IP addresses), or"
                },
                new ExplanationEntity()
                {
                    Text = "Zone-redundant services – platform replicates automatically across zones (for example, zone-redundant storage, SQL Database)."
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="What are Availability Zones in Azure?",
                    Url = "https://docs.microsoft.com/en-us/azure/availability-zones/az-overview"
                },
            },
        };
    }
}