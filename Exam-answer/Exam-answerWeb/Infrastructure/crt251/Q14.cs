using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q14
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = " Universal Containers wants to prevent sales users form modifying certain opportunity fields when the sales stage has reached Negotiation/Review.",
                },
                new ContentEntity()
                {
                    Text = "However, sales directors must be able to edit these opportunity fields in case last minute updates are required."
                },
                new ContentEntity()
                {
                    Text = "Which solution should a consultant recommend?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Modify the profile for sales directors to enable the \"Modify All\" object permission for opportunities.",                    
                },
                new AnswerEntity()
                {
                    Text = "Change the field-level security for sales representatives to restrict field access based on the sales stage.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a validation rule to enforce field access based on the sales stage and a custom permission.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a workflow rule to enable field access for sales directors based on the sales stage.",
                },
            }
        };
    }
}