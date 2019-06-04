using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q82
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 82,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters wants to implement a Partner Community to help manage an extensive distributor and reseller partner community.",
                },
                new ContentEntity()
                {
                    Text = "The consultant is setting up partner users.",
                },
                new ContentEntity()
                {
                    Text = "What are two considerations for this step in the process?",
                },
                new ContentEntity()
                {
                    Text = "Choose 2 answers.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Partner users are associated with the same set of profiles as internal users.",
                },
                new AnswerEntity()
                {
                    Text = "Partner users can own account and opportunity records in Salesforce.",            
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Partner users CANNOT receive emails generated through workflow actions.",                    
                },
                new AnswerEntity()
                {
                    Text = "The sharing model should be re-evaluated when the Partner Community is enabled.",
                    IsCorrect = true
                },
            }
        };
    }
}