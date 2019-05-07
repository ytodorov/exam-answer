using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q43
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 43,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers has enabled Social Accounts and contacts.",
                },
                new ContentEntity()
                {
                    Text = "When a sales representative accesses a contact within salesforce, the representative is unable to see detailed information from the contacts Facebook profile (e.g. contacts wall postings).",
                },
                new ContentEntity()
                {
                    Text = "What is preventing the sales representative from accessing detailed information on the contacts Facebook page?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The fields configured by Universal Containers administrator on the contact page layout are missing.",
                },
                new AnswerEntity()
                {
                    Text = "The information shown is based on the sales representative’s connection level with the contact on Facebook.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "The link to the Facebook profile is not configured with the administrator password to access detailed information.",                    
                },
                new AnswerEntity()
                {
                    Text = "Universal Containers must purchase the Facebook license to access public information for its users.",                    
                },
            }
        };
    }
}