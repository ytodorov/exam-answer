using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q52Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 52,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "*** AUTHORIZATION *** is the process of verifying a user's credentials.",
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
                    Text = "Authentication.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Federation.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Ticketing.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Authentication is the process of determining whether someone or something is, in fact, who or what it declares itself to be. Authentication technology provides access control for systems by checking to see if a user's credentials match the credentials in a database of authorized users or in a data authentication server."
                },
                new ExplanationEntity()
                {
                    Text = "Users are usually identified with a user ID, and authentication is accomplished when the user provides a credential, for example a password, that matches with that user ID. Most users are most familiar with using a password, which, as a piece of information that should be known only to the user, is called a knowledge authentication factor. "
                },
                new ExplanationEntity()
                {
                    Text = "Authorization is a security mechanism used to determine user/client privileges or access levels related to system resources, including computer programs, files, services, data and application features. Authorization is normally preceded by authentication for user identity verification. System administrators (SA) are typically assigned permission levels covering all system and user resources."
                },
                new ExplanationEntity()
                {
                    Text = "During authorization, a system verifies an authenticated user's access rules and either grants or refuses resource access."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Authentication and authorization in Azure App Service",
                    Url = "https://docs.microsoft.com/en-us/azure/app-service/overview-authentication-authorization"
                },
            },
        };
    }
}