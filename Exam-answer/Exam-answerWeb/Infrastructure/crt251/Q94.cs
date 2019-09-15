using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q94
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 94,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "A salesperson at Northern Trail Outfitters (NTO) cannot view a contact's information from social profiles.",
                },
                new ContentEntity()
                {
                    Text = "NTO has Social Accounts and Contacts turned on in its account.",
                },
                new ContentEntity()
                {
                    Text = "Why is the salesperson unable to access the information?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The fields configured by the administrator on the contact page layout are missing.",
                },
                new AnswerEntity()
                {
                    Text = "The link to the Facebook profile is NOT configured with the administrator password to access detailed information.",
                },
                new AnswerEntity()
                {
                    Text = "The information shown is based on the sales representative's social connection with the contact.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "The administrator must install and APP Exchange package to access public profile information for its users.",
                },
            }
        };
    }
}