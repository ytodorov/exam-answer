using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q35
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers has enables Advanced Currency Management.",
                },
                new ContentEntity()
                {
                    Text = "How is the converted amount data reported on a report that spans time periods when the exchange rate was different?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Converted amounts are based on exchange rates that use the oldest entry.",                    
                },
                new AnswerEntity()
                {
                    Text = "Converted amounts are based on the exchange rates entered in the opportunity.",                    
                },
                new AnswerEntity()
                {
                    Text = "Converted amounts are based on exchange rates that use the current entry.",                   
                },
                new AnswerEntity()
                {
                    Text = "Converted amounts are based on the historical exchange rate associated with the close date.",
                    IsCorrect = true
                },
            }
        };
    }
}