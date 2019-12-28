
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        /// <summary>
        /// TO DO
        /// </summary>
        public static QuestionEntity Q73Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 243,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure policy as shown in the following exhibit.",
                },
                new ContentEntity()
                {
                    Text = "What is the effect of the policy?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "You are prevented from creating Azure SQL Servers in ContosoRG1 only.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "You can create Azure SQL servers in ContosoRG1 only.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "You can create Azure SQL servers in any resource group within Subscription1.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "You are prevented from creating Azure SQL servers anywhere in Subscription1.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                },
                new ExplanationEntity()
                {
                },
                new ExplanationEntity()
                {
                },
                new ExplanationEntity()
                {
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="",
                    Url = ""
                },
                new ReferenceEntity()
                {
                    Text ="",
                    Url = ""
                }
            },
        };
    }
}