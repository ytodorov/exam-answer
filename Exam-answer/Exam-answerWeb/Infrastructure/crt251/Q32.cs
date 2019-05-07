using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q32
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers supports two lines of business: shipping and freight.",
                },
                new ContentEntity()
                {
                    Text = "The sales cycle for freight deals is more complex and involves more stages than the shipping sales cycle."
                },
                new ContentEntity()
                {
                    Text = "Which solution should a consultant recommend to meet these business requirements?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create different record types and sales processes for each line of business, and assign different stages to each page layout.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create different record types and sales processes for each line of business, and use workflow field updates to assign stages.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create different record types and sales processes for each line of business, and assign different page layouts to each record type.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create different record types and sales processes for each line of business, and assign different sales processes to each page layout.",                    
                },
            }
        };
    }
}