
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q66Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 182,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "The company currently has a Basic support plan.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a new support plan for the company. The solution must minimize costs.",
                },
                new ContentEntity()
                {
                    Text = "Which support plan should you recommend?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Premier.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Developer.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Professional Direct.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Standard.", 
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
                    Url = "https://azure.microsoft.com/en-gb/support/plans/",
                },
            },           
        };
    }
}
