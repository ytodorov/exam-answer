using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q41
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which sales methodology is described above?",
                },
                new ContentEntity()
                {
                    Text = "Universal Containers wishes to implement a sales methodology that focuses on identifying customer's challenges and addressing them with its offerings.",
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to meet this requirement?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Target account selling.",
                },
                new AnswerEntity()
                {
                    Text = "Solution selling.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Relationship selling.",                    
                },
                new AnswerEntity()
                {
                    Text = "Direct selling.",                    
                },
            }
        };
    }
}