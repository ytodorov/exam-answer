
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q1Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 2,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "When planning to migrate a public website to Azure, you must plan to *** PAY MONTHLY USAGE *** costs.",
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
                    Text = "Deploy a VPN.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Pay to transfer all the website data to Azure.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Reduce the number of connections to the website.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Pricing calculator",
                    Url = "https://azure.microsoft.com/en-in/pricing/calculator/"
                }
            },           
        };
    }
}
