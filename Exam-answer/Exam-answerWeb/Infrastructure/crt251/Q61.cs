using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q61
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 61,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) uses channel partners for selling and servicing its products.",
                },
                new ContentEntity()
                {
                    Text = "As volume of leads has increased, NTO has noticed a decrease in satisfaction from partners on the quality of leads and a noticeable decrease in the lead conversion rate.",
                },
                 new ContentEntity()
                {
                    Text = "What should the consultant suggest in order to increase partner satisfaction with the leads being shared?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Assign all leads to the partner channel manager to validate the lead data and manually assign to partners.",
                },
                new AnswerEntity()
                {
                    Text = "Use the lead score on the Find Duplicates button and assign the leads with a score in the high category.",
                },
                new AnswerEntity()
                {
                    Text = "Create a custom lead score field to assess lead quality and assign the leads that exceed this score to partners.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create multiple validation rules to ensure that all fields on the lead record are populated with data.",
                },
            }
        };
    }
}