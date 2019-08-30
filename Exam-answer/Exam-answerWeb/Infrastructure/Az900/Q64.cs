
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q63Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 175,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You need to recommend an Azure solution to limit the types of connections from the web servers to the database servers.",
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
                    Text = "Network security groups (NSGs).", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Service Bus.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A local network gateway.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A route filter.", 
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
