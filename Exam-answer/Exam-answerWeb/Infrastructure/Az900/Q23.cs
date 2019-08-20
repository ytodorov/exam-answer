using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q23Instance = new QuestionEntity()
        {
            Order = 23,
            QuestionType = QuestionType.CheckBox,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "What are two characteristics of the public cloud?",
                },
                new ContentEntity()
                {
                    Text = "Each correct answer presents a complete solution."
                },               
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Dedicated hardware.",
                },
                new AnswerEntity()
                {
                    Text = "Unsecured connections."
                },
                new AnswerEntity()
                {
                    Text = "Limited storage.",
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
                
            },
            References = new List<ReferenceEntity>()
            {
                
            }
        };
    }
}