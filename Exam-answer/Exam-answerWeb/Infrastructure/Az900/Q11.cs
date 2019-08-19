using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Az900
{
    public partial class Az900
    {
        public static QuestionEntity Q11Instance = new QuestionEntity()
        {
            Order = 11,
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
                },
                new AnswerEntity()
                {
                    Text = "Azure Analysis Services."
                },
                new AnswerEntity()
                {
                    Text = "Azure Monitor.",
                },
                new AnswerEntity()
                {
                    Text = "Azure Log Analytics.",
                    IsCorrect = true
                },
            },
            Explanations = new List<ExplanationEntity>()
            {
               
            },
            References = new List<ReferenceEntity>()
            {
                
            }
        };
    }
}