
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q26Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 35,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the underlined text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "If a resource group named RG1 has a delete lock, only a member of the global administrators group can delete RG1.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select “No change is needed”. If the statement is incorrect, select the answer choice that.",
                },
                new ContentEntity()
                {
                    Text = "Makes the statement correct.",
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
                    Text = "The delete lock must be removed before an administrator.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "An Azure policy must be modified before an administrator.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure tag must be added before an administrator.", 
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
