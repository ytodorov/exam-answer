using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q63
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 63,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters has its sales support team enter new prospecting leads for sales representatives.",
                },
                new ContentEntity()
                {
                    Text = "Which three actions should be implemented to enforce data quality and accuracy once the new lead has been qualified and the opportunity has been created to track the deal?",
                },
                new ContentEntity()
                {
                    Text = "Choose 3 answers.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Enable the lead conversion permission.",
                },
                new AnswerEntity()
                {
                    Text = "Enable validation rules on the lead.",                    
                },
                new AnswerEntity()
                {
                    Text = "Map custom lead fields to corresponding custom opportunity fields.",                    
                },
                new AnswerEntity()
                {
                    Text = "Enable validation rules on the opportunity.",
                },
                 new AnswerEntity()
                {
                    Text = "Create an Apex trigger to perform data quality checks.",
                },
            }
        };
    }
}