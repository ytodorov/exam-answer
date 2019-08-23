
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q27Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 36,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which two types of customers are eligible to use Azure Government to develop a cloud solution? Each correct answer presents a complete solution.",
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
                    Text = "A Canadian government contractor.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A European government contractor.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A United States government entity.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A United States government contractor.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A European government entity.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/learn/modules/intro-to-azure-government/2-what-is-azure-government",
                },
            },           
        };
    }
}
