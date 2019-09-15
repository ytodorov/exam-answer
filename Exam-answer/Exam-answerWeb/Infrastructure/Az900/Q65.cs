using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q64Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 177,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure DNS zone named adatum.com.",
                },
                new ContentEntity()
                {
                    Text = "You need to delegate a subdomain named research.adatum.com to a different DNS server in Azure.",
                },
                new ContentEntity()
                {
                    Text = "What should you do?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create an A record named *.research in the adatum.com zone.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create a PTR record named research in the adatum.com zone.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Modify the SOA record of adatum.com.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create an NS record named research in the adatum.com zone.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You need to create a name server (NS) record for the zone."
                },
                new ExplanationEntity()
                {
                    Text = "The A Record points your hostname to an IP address. The record A specifies IP address (IPv4) for given host. This is one of the most frequently used records in the DNS Zones."
                },
                new ExplanationEntity()
                {
                    Text = "PTR records are used for the Reverse DNS (Domain Name System) lookup. Using the IP address you can get the associated domain/hostname. An A record should exist for every PTR record. The usage of a reverse DNS setup for a mail server is a good solution."
                },
                new ExplanationEntity()
                {
                    Text = "The SOA means Start Of Authority. The SOA record defines the beginning of the authority DNS zone and specifies the global parameters for the zone. The SOA record has the following structure: \"Serial number\", \"Primary name server (NS)\", \"DNS admin e-mail\", \"Refresh Rate\", \"Retry Rate\", \"Expire time\" and \"Default TTL\"."
                },
                new ExplanationEntity()
                {
                    Text = "The NS records identify the name servers, responsible for your DNS zone. In order to have a valid DNS configuration, the NS records configured in the DNS zone must be exactly the same as these configured as name servers at your domain name provider."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Overview of DNS zones and records",
                    Url = "https://docs.microsoft.com/en-us/azure/dns/dns-zones-records",
                },
            },
        };
    }
}