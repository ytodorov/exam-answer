using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q89
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 89,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters has multiple currency enabled.",
                },
                new ContentEntity()
                {
                    Text = "Which two statements are true about opportunities in this situation?",
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
                    Text = "User's default currency overrides the specified opportunity currency.",
                },
                new AnswerEntity()
                {
                    Text = "The selected currency is used for the Amount field.",                    
                },
                new AnswerEntity()
                {
                    Text = "The selected currency is used for the Amount (Converted) field.",                    
                },
                new AnswerEntity()
                {
                    Text = "Currency must be specified for the opportunity.",
                },
            }
        };
    }
}