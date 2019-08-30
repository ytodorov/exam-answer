
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q48Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 81,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You need to identify the type of failure for which an Azure availability zone can be used to protect access to Azure services.",
                },
                new ContentEntity()
                {
                    Text = "What should you identify?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A physical server failure.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure region failure.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A storage failure.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure data center failure.", 
                    IsCorrect = true
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
