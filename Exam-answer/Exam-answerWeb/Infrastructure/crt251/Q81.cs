using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q81
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 81,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters’ European and Asia Pacific sales teams have different business requirements on how to create new opportunities.",
                },
                new ContentEntity()
                {
                    Text = "The teams must configure a set of geographically-specific fields relevant only to their team as well as common fields that both teams will utilize.",
                },
                new ContentEntity()
                {
                    Text = "Additionally, each team should NOT be able to report on the other's region-specific fields.",
                },
                new ContentEntity()
                {
                    Text = "What solution should be recommended?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Utilize Visualforce to build an opportunity page that dynamically checks the user's region to determine which fields to display.",
                },
                new AnswerEntity()
                {
                    Text = "Build a custom object with private sharing to capture the additional fields as a separate record.",                    
                },
                new AnswerEntity()
                {
                    Text = "Implement field-level security to allow access to fields for the respective regional sales teams.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create separate page layouts and record types for each of the regional sales teams.",
                },
            }
        };
    }
}