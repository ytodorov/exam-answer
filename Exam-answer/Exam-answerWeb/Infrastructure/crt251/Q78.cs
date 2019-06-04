using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q78
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 78,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A consultant needs to migrate data in Sales Cloud and is considering using Data Loader.",
                },
                new ContentEntity()
                {
                    Text = "What are two capabilities of this migration tool?",
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
                    Text = "Extract organization and configuration data.",
                },
                new AnswerEntity()
                {
                    Text = "Prevent importing duplicate records.",                    
                },
                new AnswerEntity()
                {
                    Text = "Run one-time or scheduled data loads.",       
                    IsCorrect = true                     
                },
                new AnswerEntity()
                {
                    Text = "Export field history data.",
                    IsCorrect = true
                },
            }
        };
    }
}