
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q0Instance = new QuestionEntity()
        {
            Order = 1,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What are two characteristics of the public cloud? Each correct answer presents a complete solution.",
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

            References = new List<ReferenceEntity>()
            {
            },           
        };
    }
}
