using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q75
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 75,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters has organization-wide defaults set to private. Sales representatives own the accounts and want to collaborate with relevant people from other departments (e.g., marketing and finance).",
                },
                new ContentEntity()
                {
                    Text = "Collaborating team members must be able to access and report on relevant data.",
                },
                new ContentEntity()
                {
                    Text = "Which two solutions should be recommended?",
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
                    Text = "Use Chatter to share records with relevant people.",
                },
                new AnswerEntity()
                {
                    Text = "Use manual sharing on account to share specific records.",                    
                },
                new AnswerEntity()
                {
                    Text = "Use account team to share records to relevant people.",      
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Use opportunity team to share records with relevant people.",
                    IsCorrect = true
                },
            }
        };
    }
}