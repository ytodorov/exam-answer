
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q7Instance = new QuestionEntity()
        {
            Order = 8,
            Section = "",
            Contents = new List<ContentEntity>()
            {


                    new ContentEntity()
                {
                    Text = "Note: This question is part of a series of questions that present the same scenario. Each question in the series contains a unique solution that might.",
                },

                    new ContentEntity()
                {
                    Text = "Meet the stated goals. Some question sets might have more than one correct solution, while others might not have a correct solution..",
                },

                    new ContentEntity()
                {
                    Text = "After you answer a question in this section, you will NOT be able to return to it. As a result, these questions will not appear in the review screen..",
                },

                    new ContentEntity()
                {
                    Text = "You plan to deploy several Azure virtual machines..",
                },

                    new ContentEntity()
                {
                    Text = "You need to ensure that the services running on the virtual machines are available if a single data center fails..",
                },

                    new ContentEntity()
                {
                    Text = "Solution: You deploy the virtual machines to two or more scale sets..",
                },

                    new ContentEntity()
                {
                    Text = "Does this meet the goal?.",
                },

            },

                        Answers = new List<AnswerEntity>()
            {


                    new AnswerEntity()
                {
                    Text = "Yes.", 
                    IsCorrect = false
                },

                    new AnswerEntity()
                {
                    Text = "No.", 
                    IsCorrect = true
                },

            },           
        };
    }
}
