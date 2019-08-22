
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q3Instance = new QuestionEntity()
        {
            Order = 4,
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
                    Text = "Your company plans to migrate all its data and resources to Azure..",
                },

                    new ContentEntity()
                {
                    Text = "The company’s migration plan states that only platform as a service (PaaS) solutions must be used in Azure..",
                },

                    new ContentEntity()
                {
                    Text = "You need to deploy an Azure environment that supports the planned migration..",
                },

                    new ContentEntity()
                {
                    Text = "Solution: You create an Azure App Service and Azure virtual machines that have Microsoft SQL Server installed..",
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
