
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q109Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 245,
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
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/dns/delegate-subdomain",
                },
            },           
        };
    }
}
