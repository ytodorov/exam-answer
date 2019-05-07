using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q30
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What are two capabilities of Data Loader?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Ability to extract organization and configuration data.",
                },
                new AnswerEntity()
                {
                    Text = "Ability to prevent importing duplicate records.",
                },
                new AnswerEntity()
                {
                    Text = "Ability to export field history data.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Ability to run one-time or scheduled data loads.",
                    IsCorrect = true
                },
            }
        };
    }
}