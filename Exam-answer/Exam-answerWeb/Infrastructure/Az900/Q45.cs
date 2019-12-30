using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q45Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 45,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to migrate to Azure. The company has several departments. All the Azure resources used by each department will be managed by a department administrator.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend an Azure deployment that provides the ability to segment Azure for the departments. The solution must minimize administrative effort.",
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
                    Text = "Multiple subscriptions.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Multiple Azure Active Directory (Azure AD) directories.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Multiple regions.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Multiple resource groups.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "A subscription is an agreement with Microsoft to use one or more Microsoft cloud platforms or services, for which charges accrue based on either a per-user license fee or on cloud-based resource consumption. Microsoft's Software as a Service (SaaS)-based cloud offerings (Office 365, Intune/EMS, and Dynamics 365) charge per-user license fees. Microsoft's Platform as a Service (PaaS) and Infrastructure as a Service (IaaS) cloud offerings (Azure) charge based on cloud resource consumption."
                },
                new ExplanationEntity()
                {
                    Text = "You can also use a trial subscription, but the subscription expires after a specific amount of time or consumption charges. You can convert a trial subscription to a paid subscription."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Subscriptions, licenses, accounts, and tenants for Microsoft's cloud offerings",
                    Url = "https://docs.microsoft.com/en-us/office365/enterprise/subscriptions-licenses-accounts-and-tenants-for-microsoft-cloud-offerings"
                },
            },
        };
    }
}