
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q102Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 238,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Note: This question is part of a series of questions that present the same scenario. Each question in the series contains a unique solution that might.",
                },
                new ContentEntity()
                {
                    Text = "Meet the stated goals. Some question sets might have more than one correct solution, while others might not have a correct solution.",
                },
                new ContentEntity()
                {
                    Text = "After you answer a question in this section, you will NOT be able to return to it. As a result, these questions will not appear in the review screen.",
                },
                new ContentEntity()
                {
                    Text = "Your company registers a domain name of contoso.com.",
                },
                new ContentEntity()
                {
                    Text = "You create an Azure DNS zone named contoso.com, and then you add an A record to the zone for a host named www that has an IP address of 131.107.1.10.",
                },
                new ContentEntity()
                {
                    Text = "You discover that Internet hosts are unable to resolve www.contoso.com to the 131.107.1.10 IP address.",
                },
                new ContentEntity()
                {
                    Text = "You need to resolve the name resolution issue.",
                },
                new ContentEntity()
                {
                    Text = "Solution: You create a PTR record for www in the contoso.com zone.",
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
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "No.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Modify the Name Server (NS) record."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/dns/dns-delegate-domain-azure-dns",
                },
            },           
        };
    }
}
