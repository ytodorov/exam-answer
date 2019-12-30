using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q48Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 48,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "One of the benefits of Azure SQL Data Warehouse is that *** HIGH AVAILABILITY *** is built into the platform.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the UPPER-CASED text surrounded by ***. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Automatic scaling.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Data compression.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Versioning.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "SQL Data Warehouse is supported by a broad ecosystem of partners, including data preparation, ingestion service and visualisation tool providers. Enjoy guaranteed 99.9 percent availability in 40 Azure regions worldwide."
                },
                new ExplanationEntity()
                {
                    Text = "Service capabilities:"
                },
                new ExplanationEntity()
                {
                    Text = "* Massive query concurrency - Democratise data across your enterprise."
                },
                new ExplanationEntity()
                {
                    Text = "* Integrated data processing - Ingest and query from multiple data types and sources within a single solution."
                },
                new ExplanationEntity()
                {
                    Text = "* Quick and easy provisioning - Provision thousands of compute cores in less than five minutes and scale to a petabyte in hours."
                },
                new ExplanationEntity()
                {
                    Text = "* Elastic design - Independently scale for performance or memory with separate compute and storage."
                },
                new ExplanationEntity()
                {
                    Text = "* Advanced security - Help protect your data with virtual network service endpoints, advanced threat detection, always-on encryption, auditing and simplified secure access."
                },
                new ExplanationEntity()
                {
                    Text = "* Fully managed infrastructure - Automate infrastructure allocation and workload optimisation to focus on data analysis and use the built-in advisor to optimise your cloud data warehouse."
                },
                new ExplanationEntity()
                {
                    Text = "* Strong Ecosystem - Integrate with leading data preparation and visualisation vendors and get support from our partners to accelerate time to value."
                },
                new ExplanationEntity()
                {
                    Text = "* Powerful SQL engine - Take advantage of Microsoft SQL Server, the industry’s top-performing SQL engine, offering comprehensive support for SQL language."
                },
                new ExplanationEntity()
                {
                    Text = "* Industry-leading compliance - Help ensure peace of mind with more than 50 government and industry compliance certifications, including HIPAA."
                },
                new ExplanationEntity()
                {
                    Text = "* Global availability - Benefit from availability in 40 Azure regions, the most among all cloud-based data warehouse providers."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="SQL Data Warehouse",
                    Url = "https://azure.microsoft.com/en-in/services/sql-data-warehouse/"
                },
                new ReferenceEntity()
                {
                    Text ="Compare Azure SQL Database vs. Azure SQL Data Warehouse: Definitions, Differences and When to Use",
                    Url = "https://stackify.com/azure-sql-database-vs-warehouse/"
                }
            },
        };
    }
}