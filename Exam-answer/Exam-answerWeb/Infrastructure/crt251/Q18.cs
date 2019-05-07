using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q18
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 18,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers allows its sales representatives to negotiate up to a 5% discount for their opportunities.",
                },
                new ContentEntity()
                {
                    Text = "Discounts greater than 5% must be sent to their Regional Sales Manager (RSM) to approval."
                },
                new ContentEntity()
                {
                    Text = "Discounts greater than 15% must also be sent to the Regional Vice President (RVP) for approval."
                },
                new ContentEntity()
                {
                    Text = "Which approach would satisfy these requirements?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Configure an approval process for the RSM and a workflow rule for the RVP.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create two approval processes, one for the RSM and one for the RVP.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create the two-step approval process for the RSM and RVP as approvers.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Configure a workflow approval task and email to notify the RSM and RVP.",
                },
            }
        };
    }
}