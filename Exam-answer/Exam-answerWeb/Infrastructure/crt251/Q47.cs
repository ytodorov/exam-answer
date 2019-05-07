using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q47
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "The shipping department at Universal Containers is responsible for sending product samples as part of the sales process.",
                },
                new ContentEntity()
                {
                    Text = "When an opportunity moves to the \"sampling\" stage, Universal Containers wants an automatic email sent to the shipping department listing the products on the opportunity.",
                },
                new ContentEntity()
                {
                    Text = "How can this requirement be met using a workflow email?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create it on the opportunity using a Visualforce email template.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create it on the opportunity product using a Visualforce email template.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create it on the opportunity using a HTML email template.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create it on the opportunity product using an HTML email template.",                    
                },
            }
        };
    }
}