using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q29
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers has set the organization-wide default to public read-only for accounts, contacts, and opportunities.",
                },
                new ContentEntity()
                {
                    Text = "Activities are set to be controlled by the parent.",
                },
                new ContentEntity()
                {
                    Text = "The ABC Corporation account is owned by a sales user whose profile grants create, read, edit, and delete access to accounts, contacts, and opportunities.",
                },
                new ContentEntity()
                {
                    Text = "Which two actions does the owner of the ABC Corporation account have the right to take? (Choose two.)",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "View, edit, and delete activities owned by other users directly related to the account.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "View, edit, and delete related contacts and opportunities owned by other users.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Share the account with other users through manual sharing and account teams.",                    
                },
                new AnswerEntity()
                {
                    Text = "Transfer ownership of related contacts and opportunities owned by other users.",                    
                },
            }
        };
    }
}