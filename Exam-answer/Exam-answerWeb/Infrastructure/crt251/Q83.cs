using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q83
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 83,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Sales directors at Northern Trail Outfitters (NTO) need access to edit opportunity fields in the case of last minute updates once the sales stage reaches Negotiation/Review; however, sales representatives should not have editing rights at that stage.",
                },
                new ContentEntity()
                {
                    Text = "Which solution should the consultant advise?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a validation rule to enforce field access based on the sales stage and a custom permission.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a workflow rule to enable field access for sales directors based on the sales stage.",                    
                },
                new AnswerEntity()
                {
                    Text = "Modify the profile for sales directors to enable the \"Modify All\" object permission for opportunities.",                    
                },
                new AnswerEntity()
                {
                    Text = "Change the field-level security for sales representatives to restrict field access based on the sales stage.",
                },
            }
        };
    }
}