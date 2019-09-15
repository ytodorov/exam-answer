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
                new ExplanationEntity()
                {
                    Text = "Azure Data Lake includes all the capabilities required to make it easy for developers, data scientists, and analysts to store data of any size, shape, and speed, and do all types of processing and analytics across platforms and languages. It removes the complexities of ingesting and storing all of your data while making it faster to get up and running with batch, streaming, and interactive analytics. Azure Data Lake works with existing IT investments for identity, management, and security for simplified data management and governance. It also integrates seamlessly with operational stores and data warehouses so you can extend current data applications. We’ve drawn on the experience of working with enterprise customers and running some of the largest scale processing and analytics in the world for Microsoft businesses like Office 365, Xbox Live, Azure, Windows, Bing, and Skype. Azure Data Lake solves many of the productivity and scalability challenges that prevent you from maximizing the value of your data assets with a service that’s ready to meet your current and future business needs."
                },
                new ExplanationEntity()
                {
                    Text = "Unlock new insights from your data with Azure SQL Data Warehouse, a fully managed cloud data warehouse for enterprises of any size that combines lightning-fast query performance with industry-leading data security. Optimise workloads by elastically scaling your resources in minutes. Get unlimited storage, automated administration and built-in auditing and threat detection. Integrate seamlessly with Azure Active Directory, Azure Data Factory, Azure Data Lake Storage, Azure Databricks and Microsoft Power BI to provide a single holistic modern data warehouse solution for all your analytical workloads."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "SQL Data Warehouse",
                    Url = "https://azure.microsoft.com/en-in/services/sql-data-warehouse/"
                },
                new ReferenceEntity()
                {
                    Text = "https://stackify.com/azure-sql-database-vs-warehouse/",
                    Url = "https://stackify.com/azure-sql-database-vs-warehouse/"
                },
            },
        };
    }
}