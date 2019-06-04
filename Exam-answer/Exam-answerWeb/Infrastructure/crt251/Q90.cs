using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q90
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 90,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = @" Northern Trail Outfitters has two sales divisions:
* An individual sales division, and
* A business sales division.",
                },
                new ContentEntity()
                {
                    Text = "The sales representatives for each division have their own user profiles and person accounts.",
                },
                new ContentEntity()
                {
                    Text = "The business sales division sales representatives cannot create person accounts and they should only be able to set up business accounts.",
                },
                new ContentEntity()
                {
                    Text = "How can these requirements be met?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Remove person account record types from the business sales division's sales representative user profile.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Check the “disable person accounts” permission on the business sales division's sales representative user profile.",                    
                },
                new AnswerEntity()
                {
                    Text = "Use field-level security to hide the “Is Person Account” checkbox from the business sales division's sales representative user profile.",                    
                },
                new AnswerEntity()
                {
                    Text = "Use Divisions to hide person accounts from the business sales division's sales representative user profile.",
                },
            }
        };
    }
}