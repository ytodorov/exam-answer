using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q77
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 77,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) wants to boost the importance of its sales stages and their role in NTO's sales methodology; they also want to enhance the precision of their sales forecast.",
                },
                new ContentEntity()
                {
                    Text = "How should the steps in the sales process be mapped so NTO's requirements are met?",
                },              
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Map sales probability values to forecast categories; assign sales stages accurate percentages.",
                },
                new AnswerEntity()
                {
                    Text = "Map forecast probability to opportunity probability; assign appropriate sales stage.",                    
                },
                new AnswerEntity()
                {
                    Text = "Map appropriate sales stage to opportunity stage; assign accurate forecast probability.",                    
                },
                new AnswerEntity()
                {
                    Text = "Map opportunity stages to forecast categories; assign accurate probability to each stage.",
                },
            }
        };
    }
}