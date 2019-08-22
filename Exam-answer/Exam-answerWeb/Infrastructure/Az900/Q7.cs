using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q6Instance = new QuestionEntity()
        {
            Order = 7,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                    new ContentEntity()
                {
                    Text = "You have an on-premises network that contains 100 servers..",
                },

                    new ContentEntity()
                {
                    Text = "You need to recommend a solution that provides additional resources to your users. The solution must minimize capital and operational expenditure costs..",
                },

                    new ContentEntity()
                {
                    Text = "What should you include in the recommendation?.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                    new AnswerEntity()
                {
                    Text = "A complete migration to the public cloud.",
                    IsCorrect = false
                },

                    new AnswerEntity()
                {
                    Text = "An additional data center.",
                    IsCorrect = false
                },

                    new AnswerEntity()
                {
                    Text = "A private cloud.",
                    IsCorrect = true
                },

                    new AnswerEntity()
                {
                    Text = "A hybrid cloud.",
                    IsCorrect = false
                },
            },
        };
    }
}