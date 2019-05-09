using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q95
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 95,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) has a multi-step selling process; every sales stage coincides with a step in this process.",
                },
                new ContentEntity()
                {
                    Text = "The first step is preliminary qualification in which opportunities should not contribute to NTO's forecast.",
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
                    Text = "Instruct sales users to enter $0 for the opportunity amount.",
                },
                new AnswerEntity()
                {
                    Text = "Override the forecast to be $0 for first stage opportunities.",                    
                },
                new AnswerEntity()
                {
                    Text = "Assign 0% probability to the first sales stage.",                    
                },
                new AnswerEntity()
                {
                    Text = "Configure the first stage with the omitted forecast category.",
                },
            }
        };
    }
}