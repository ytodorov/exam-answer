using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q64
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 64,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which two processes should minimize changes in project scope during the design and build phases, post sign-off, when using a traditional waterfall project methodology?",
                },                
                new ContentEntity()
                {
                    Text = "Choose 2 answers.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Obtain customer sign-off on the solution design.",
                },
                new AnswerEntity()
                {
                    Text = "Map solution design documents to system test scripts.",                    
                },
                new AnswerEntity()
                {
                    Text = "Map business requirements to the solution design.",                    
                },
                new AnswerEntity()
                {
                    Text = "Update requirements based on feedback from key stakeholders.",
                },
            }
        };
    }
}