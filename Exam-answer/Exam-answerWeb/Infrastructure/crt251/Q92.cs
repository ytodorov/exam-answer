using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q92
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 92,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A sales manager at Northern Trail Outfitters (NTO) needs to give the another manager access to an account as well as its four child accounts.",
                },
                new ContentEntity()
                {
                    Text = "NTO has account hierarchies with a private sharing model.",
                },
                new ContentEntity()
                {
                    Text = "How should the sales manager enable access?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Add the user to a public group for that account and share all child accounts to this group.",
                },
                new AnswerEntity()
                {
                    Text = "Add the user manually to the parent account team and each of the child account teams.",                    
                },
                new AnswerEntity()
                {
                    Text = "Add the user to the account team on the parent account; the child accounts will inherit access.",                    
                },
                new AnswerEntity()
                {
                    Text = "Add the user to each child account team; visibility will then roll up to the parent account.",
                },
            }
        };
    }
}