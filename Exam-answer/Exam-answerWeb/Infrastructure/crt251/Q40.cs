using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q40
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers requires its sales representatives to go through an internal certification process to sell certain groups of products.",
                },
                new ContentEntity()
                {
                    Text = "Which two actions prevent a sales representative from adding these products to opportunities if they are NOT certified to sell them? (Choose two.)",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Use a validation rule on opportunity products to prevent them from adding products marked as required certification if they are NOT certified.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Use a validation rule on products marked as requiring certification to prevent them from being added to an opportunity.",                  
                },
                new AnswerEntity()
                {
                    Text = "Use a criteria-based sharing rule on products marked as requiring certification to only share the products to users who are certified.",                    
                },
                new AnswerEntity()
                {
                    Text = "Use a separate price book for the products requiring certification and only share the price book to users who are certified.",
                    IsCorrect = true
                },
            }
        };
    }
}