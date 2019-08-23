
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q106Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 242,
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
                    Text = "MX.", 
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
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/dns/dns-web-sites-custom-domain",
                },
            },           
        };
    }
}
