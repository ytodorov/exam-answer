using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q16
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers plans to implement lead management functionality for channel sales representatives who need to push pre-qualified leads to their partners.",
                },
                new ContentEntity()
                {
                    Text = "Partners need the ability to access and update the leads assigned to them."
                },
                new ContentEntity()
                {
                    Text = "Which solution should a consultant recommend for this scenario?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a customized site where partners can self-register and access their leads.",                    
                },
                new AnswerEntity()
                {
                    Text = "Configure a separate leas record type and page layout for the Partner Community.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a task for a partner when a new lead is created and assign the task to the partner in the Partner Community.",                   
                },
                new AnswerEntity()
                {
                    Text = "Add the leads tab to the Partner Community and configure partner profiles to access leads.",
                    IsCorrect = true
                },
            }
        };
    }
}