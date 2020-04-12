using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q30Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 30,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "To what should an application connect to retrieve security tokens?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "An Azure Storage account.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Active Directory (Azure AD).",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A certificate store.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure key vault.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Microsoft identity platform is an evolution of the Azure Active Directory (Azure AD) developer platform. It allows developers to build applications that sign in all Microsoft identities and get tokens to call Microsoft APIs such as Microsoft Graph or APIs that developers have built. It's a full-featured platform that consists of an OAuth 2.0 and OpenID Connect standard-compliant authentication service, open-source libraries, application registration and configuration, robust conceptual and reference documentation, quickstart samples, code samples, tutorials, and how-to guides."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Microsoft identity platform (formerly Azure Active Directory for developers)",
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/develop/"
                },
            },
        };
    }
}