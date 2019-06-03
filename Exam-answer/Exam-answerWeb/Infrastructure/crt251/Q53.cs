using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q53
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 53,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) wants to launch an email campaign for its new winter gear.",
                },
                new ContentEntity()
                {
                    Text = "The NTO sales representatives will review the response to the campaign and determine who the decision makers are prior to beginning the sales process with each respondent.",
                },
                new ContentEntity()
                {
                    Text = "What set of steps should the consultant recommend for NTO?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a campaign, qualify the respondents, and create accounts and contacts.",
                },
                new AnswerEntity()
                {
                    Text = "Create a campaign, associate the leads to the campaign, and qualify the respondents.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create leads, convert them to opportunities, and qualify the respondents on the opportunities.",
                },
                new AnswerEntity()
                {
                    Text = "Create both account and contact records, then associate the contacts to the campaign.",
                },
            }
        };
    }
}