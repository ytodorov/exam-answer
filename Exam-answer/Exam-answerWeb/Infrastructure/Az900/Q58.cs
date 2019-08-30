
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q57Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 156,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "NOTE: Each correct selection is worth one point.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Dedicated hardware.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Unsecured connections.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Limited storage.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Metered pricing.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Self-service management.", 
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
