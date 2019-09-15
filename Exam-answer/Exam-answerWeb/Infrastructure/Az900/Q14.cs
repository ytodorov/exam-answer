using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q13Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 19,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "An Azure region *** CONTAINS ONE OR MORE DATA CENTERS *** that are connected by using a low-latency network.",
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
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Is found in each country where Microsoft has a subsidiary office.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Can be found in every country in Europe and the Americas only.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Contains one or more data centers that are connect by using a high-latency network.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Understand Azure global infrastructure:"
                },
                new ExplanationEntity()
                {
                    Text = "A region is a set of datacenters deployed within a latency-defined perimeter and connected through a dedicated regional low-latency network. With more global regions than any other cloud provider, Azure gives customers the flexibility to deploy applications where they need to. Azure is generally available in 46 regions around the world, with plans announced for 8 additional regions."
                },
                new ExplanationEntity()
                {
                    Text = "A geography is a discrete market, typically containing two or more regions, that preserves data residency and compliance boundaries. Geographies allow customers with specific data-residency and compliance needs to keep their data and applications close. Geographies are fault-tolerant to withstand complete region failure through their connection to our dedicated high-capacity networking infrastructure."
                },
                new ExplanationEntity()
                {
                    Text = "Availability Zones are physically separate locations within an Azure region. Each Availability Zone is made up of one or more datacenters equipped with independent power, cooling, and networking. Availability Zones allow customers to run mission-critical applications with high availability and low-latency replication."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure regions",
                    Url = "https://azure.microsoft.com/en-us/global-infrastructure/regions/"
                }
            },
        };
    }
}