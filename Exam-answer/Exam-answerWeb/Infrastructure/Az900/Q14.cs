
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q13Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 19,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the underlined text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "An Azure region contains one or more data centers that are connected by using a low-latency network.",
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
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Is found in each country where Microsoft has a subsidiary office.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Can be found in every country in Europe and the Americas only.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Contains one or more data centers that are connect by using a high-latency network.", 
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
