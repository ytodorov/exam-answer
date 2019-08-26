
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q11Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 15,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which Azure service should you use to correlate events from multiple resources into a centralized repository?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Event Hubs.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Analysis Services.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Monitor.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Log Analytics.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text ="Log Analytics is a web tool used to write and execute Azure Monitor log queries. Open it by selecting Logs in the Azure Monitor menu. It starts with a new blank query."
                }
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure Monitor",
                    Url = "https://azure.microsoft.com/en-us/services/monitor/"
                }
            },           
        };
    }
}
