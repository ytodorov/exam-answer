
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q33Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 42,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What can Azure Information Protection encrypt?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Network traffic.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Documents and email messages.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "An Azure Storage account.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure SQL database.", 
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
                    Url = "https://docs.microsoft.com/en-us/azure/information-protection/compliance",
                },
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/information-protection/quickstart-label-dnf-protectedemail",
                },
            },           
        };
    }
}
