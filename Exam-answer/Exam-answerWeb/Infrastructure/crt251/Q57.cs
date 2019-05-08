using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q57
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 57,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters' partners need the new quoting functionality that was recently implemented for sales representatives.",
                },
                new ContentEntity()
                {
                    Text = "What should be recommended?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a custom quote object to capture partner quotes on opportunities separate from non-partner quotes.",
                },
                new AnswerEntity()
                {
                    Text = "Grant partner access to quotes and add the quotes related list to the partner opportunity page layouts.",
                },
                new AnswerEntity()
                {
                    Text = "Update the partner sales process to include stages for managing and submitting partner quotes.",
                },
                new AnswerEntity()
                {
                    Text = "Enable quotes and content in the Partner Communities to allow partners to store their PDF quotes.",
                },
            }
        };
    }
}