using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q67
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 67,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = @"Northern Trail Outfitters (NTO) has configured a private sharing model for the following:
* Accounts
* Opportunities",
                },
                new ContentEntity()
                {
                    Text = "As part of NTO's sales strategy, each sales representative collaborates with the same set of individuals for each opportunity.",
                },
                 new ContentEntity()
                {
                    Text = "How should sales representatives be given appropriate access to an opportunity?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Enable opportunity team selling and have each sales representative configure his or her default opportunity team.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a public group for each team and have the sales representatives manually share the opportunity with their respective group.",
                },
                new AnswerEntity()
                {
                    Text = "Enable Chatter and configure a customer Chatter group for the opportunity to allow collaboration on ideas.",
                },
                new AnswerEntity()
                {
                    Text = "Create a trigger for each sales representative that would automatically share the opportunity with his or her default opportunity team.",
                },
            }
        };
    }
}