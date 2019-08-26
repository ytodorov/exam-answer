
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q52Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 92,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "Azure Germany can be used by *** LEGAL RESIDENTS OF GERMANY ONLY ***.",
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
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Only enterprises that are registered in Germany.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Only enterprises that purchase their azure licenses from a partner based in Germany.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Any user or enterprise that requires its data to reside in Germany.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/germany/germany-welcome?toc=%2fazure%2fgermany%2ftoc.json",
                },
            },           
        };
    }
}
