using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q58
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 58,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Sales representatives at Northern Trail Outfitters are creating opportunities after they are closed/won.",
                },
                new ContentEntity()
                {
                    Text = "Sales management is concerned that pipeline and forecasting reports are inaccurate because of this.",
                },
                new ContentEntity()
                {
                    Text = "Choose 2 answers.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Use a workflow rule to email sales management when the opportunity is created in the closed/won stage.",
                },
                new AnswerEntity()
                {
                    Text = "Create a workflow rule that automatically updates the opportunity to the first stage in the sales process.",                    
                },
                new AnswerEntity()
                {
                    Text = "Run the opportunity pipeline standard report to view the upcoming opportunities by stage.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a report that displays opportunities that have a closed date less than or equal to the created date.",
                },
            }
        };
    }
}