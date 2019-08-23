
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q16Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 22,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You plan to store 20 TB of data in Azure. The data will be accessed infrequently and visualized by using Microsoft Power BI.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a storage solution for the data.",
                },
                new ContentEntity()
                {
                    Text = "Which two solutions should you recommend? Each correct answer presents a complete solution.",
                },
                new ContentEntity()
                {
                    Text = "NOTE: Each correct selection is worth one point.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Data Lake.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Cosmos DB.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure SQL Data Warehouse.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure SQL Database.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Database for PostgreSQL.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
            },           
        };
    }
}
