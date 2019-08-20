using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q1Instance = new QuestionEntity()
        {
            Order = 1,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASE text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "An organization that hosts its infrastructure IN A PRIVATE CLOUD can decommission its data center."
                },
                new ContentEntity()
                {
                    Text = "Review the UPPER-CASE text. If it makes the statement correct, select “No change is needed”. If the statement is incorrect, select the answer choice that makes the statement correct."
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.",
                },
                new AnswerEntity()
                {
                    Text = "In a hybrid cloud."
                },
                new AnswerEntity()
                {
                    Text = "In the public cloud.",
                    IsCorrect =  true,
                },
                new AnswerEntity()
                {
                    Text = "On a Hyper-V host."
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