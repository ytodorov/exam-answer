using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q42
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 42,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to support selling the two product lines?",
                },
                new ContentEntity()
                {
                    Text = "Universal Containers sells two product lines that each use a distinct selling methodology.",
                },
                new ContentEntity()
                {
                    Text = "Additionally, each product line captures different information that is used to sell the products.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a one page layout, two sales processes, and validation rules to capture relevant opportunity information.",
                },
                new AnswerEntity()
                {
                    Text = "Create two page layouts and two sales processes; assign them to the respective product lines to collect relevant information.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create two sales processes and two page layouts; assign them to two different opportunity record types for each product line.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create two page layouts, one opportunity record type, and one workflow rule to assign the correct page layout to the record type.",                    
                },
            }
        };
    }
}