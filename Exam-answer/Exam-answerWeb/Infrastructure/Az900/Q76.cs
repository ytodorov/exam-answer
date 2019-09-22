
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q106Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 200,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure Active Directory (Azure AD) tenant named contosocloud.onmicrosoft.com.",
                },
                new ContentEntity()
                {
                    Text = "Your company has a public DNS zone for contoso.com.",
                },
                new ContentEntity()
                {
                    Text = "You add contoso.com as a custom domain name to Azure AD.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that Azure can verify the domain name.",
                },
                new ContentEntity()
                {
                    Text = "Which type of DNS record should you create?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "TXT.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "SRV.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "DNSKEY.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "NSEC.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "RRSIG.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "PTR.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You can configure Azure DNS to host a custom domain for your web apps. For example, you can create an Azure web app and have your users access it using either www.contoso.com or contoso.com as a fully qualified domain name (FQDN)."
                },
                new ExplanationEntity()
                {
                    Text = "To do this, you have to create three records:"
                },
                new ExplanationEntity()
                {
                    Text = "* A root \"A\" record pointing to contoso.com"
                },
                new ExplanationEntity()
                {
                    Text = "A root \"TXT\" record for verification"
                },
                new ExplanationEntity()
                {
                    Text = "A \"CNAME\" record for the www name that points to the A record"
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Tutorial: Create DNS records in a custom domain for a web app",
                    Url = "https://docs.microsoft.com/en-us/azure/dns/dns-web-sites-custom-domain",
                },
            },
        };
    }
}