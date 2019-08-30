
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q58Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 157,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "When planning to migrate a public website to Azure, you must plan to pay monthly usage costs.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
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
                    Text ="",
                    Url = ""
                },
                new ReferenceEntity()
                {
                    Text ="",
                    Url = ""
                }
            },                
        };
    }
}
