using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q79
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 79,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) wants controlled access for its users allowing them to see all accounts, but only make changes to the accounts they own and the contacts within those accounts.",
                },
                new ContentEntity()
                {
                    Text = "How should NTO set its default access for accounts and contacts?",
                },              
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Set accounts to private and contacts to controlled by parent.",
                },
                new AnswerEntity()
                {
                    Text = "Set accounts to public read-only and contacts to controlled by parent.",           
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Set accounts to public read-only and contacts to private.",                    
                },
                new AnswerEntity()
                {
                    Text = "Set accounts to private and contacts to private.",
                },
            }
        };
    }
}