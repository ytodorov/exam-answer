using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q24
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 24,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which two actions can a consultant take during the project planning phase to ensure client stakeholder goals are met? (Choose two.)",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create scheduled dashboard to be sent weekly to all stakeholders.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Ensure the project key performance indicators are profitable.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Acquire the client stakeholder's key performance indicators.",                    
                },
                new AnswerEntity()
                {
                    Text = "Establish a stakeholder committee and meeting schedule.",                    
                },
            }
        };
    }
}