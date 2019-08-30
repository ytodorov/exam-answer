
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q91Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 224,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You are troubleshooting a performance issue for an Azure Application Gateway.",
                },
                new ContentEntity()
                {
                    Text = "You need to compare the total requests to the failed requests during the past six hours.",
                },
                new ContentEntity()
                {
                    Text = "What should you use?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "NSG flow logs in Azure Network Watcher.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Metrics in Application Gateway.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Connection monitor in Azure Network Watcher.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Diagnostics logs in Application Gateway.", 
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
                    Url = "https://docs.microsoft.com/en-us/azure/application-gateway/application-gateway-diagnostics#metrics",
                },
            },           
        };
    }
}
