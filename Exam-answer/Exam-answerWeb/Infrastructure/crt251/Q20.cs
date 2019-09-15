using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q20
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 20,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers uses a custom object named “Analysis”, which is the child in a master-detail relationship with the Opportunity object.",
                },
                new ContentEntity()
                {
                    Text = "Sales teams use this object to create requests for supporting research."
                },
                new ContentEntity()
                {
                    Text = "Sales teams use the Salesforce Mobile App and want to easily create new Analysis records from their phones."
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to meet this requirement?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a Visualforce page.",
                },
                new AnswerEntity()
                {
                    Text = "Create an Action.",
                },
                new AnswerEntity()
                {
                    Text = "Create a related list button.",
                },
                new AnswerEntity()
                {
                    Text = "Create a custom object tab.",
                    IsCorrect = true
                },
            }
        };
    }
}