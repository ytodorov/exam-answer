using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q72
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 72,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "How is the campaign influence for opportunities impacted when a contact is associated to an opportunity in a contact role, if the influence timeframe for a campaign is 60 days?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Sales reps can choose which campaigns created within the last 60 days should be added to the campaign influence related list.",
                },
                new AnswerEntity()
                {
                    Text = "All campaigns created within the last 60 days will be added to the campaign influence related list.",
                },
                new AnswerEntity()
                {
                    Text = "Campaigns in which a contact became a member within the last 60 days will be associated and displayed in Campaigns with Influenced Opportunities Report.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "All contacts associated with campaigns will be added to the campaign influence related list.",
                },
            }
        };
    }
}