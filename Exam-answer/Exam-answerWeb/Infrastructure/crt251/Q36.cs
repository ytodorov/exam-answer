using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q36
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Sales management at Universal Containers wants product managers to become more involved with sales deals that are being delayed in the negotiation stage of the sales process.",
                },
                new ContentEntity()
                {
                    Text = "Product managers need to understand the details of specific sales deals, and address product capability and roadmap questions with customers.",
                },
                new ContentEntity()
                {
                    Text = "Which two solutions should a consultant recommend to help product managers engage in sales deals? (Choose two.)",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a Chatter group to share product information with the sales team, product managers, and customers.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Use Process Builder to create a chatter post.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Use an assignment to notify product managers when opportunities are updated.",                    
                },
                new AnswerEntity()
                {
                    Text = "Add the opportunity team, product managers, and customers to libraries containing files relevant to sales deals.",                    
                },
            }
        };
    }
}