
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q54Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 153,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "When you are implementing a software as a service (SaaS) solution, you are responsible for configuring high availability.",
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
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Defining scalability rules.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Installing the SaaS solution.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Configuring the SaaS solution.", 
                    IsCorrect = true
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
