using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q70
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 70,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Sales directors at Northern Trail Outfitters (NTO) cannot see or update their teams' forecasts.",
                },                
                new ContentEntity()
                {
                    Text = "Sales representatives are constantly asked to provide the directors with their updated forecast information.",
                },
                new ContentEntity()
                {
                    Text = "Which two methods should NTO use to correct how forecasts are managed?",
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
                    Text = "Configure weekly customized forecast reports and dashboards to be emailed to sales management.",
                },
                new AnswerEntity()
                {
                    Text = "Enable override forecast permission in the Manager's profile.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create forecast Chatter groups where sales representatives can post and share their forecasts.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a forecast hierarchy and assign managers to the forecast manager role.",
                },
            }
        };
    }
}