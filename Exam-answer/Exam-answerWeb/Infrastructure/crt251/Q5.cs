using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q5
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 5,
            QuestionType = QuestionType.RadioButon,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What is the recommended approach to relate a Person Account to another Account?",
                },
                new ContentEntity()
                {
                    Text = "Choose the correct answer."
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Add the Person Account to the Contact Roles.",
                },
                new AnswerEntity()
                {
                    Text = "Add the Person Account to the Account owner's default team.",                    
                },
                new AnswerEntity()
                {
                    Text = "Add the Person Account to the Partners Related List.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Add the Person Account to the Account Team.",
                },
            }
        };
    }
}