using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q100
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 100,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Sales management at Universal Containers needs to provide channel partners with easy access to approved product documentation. Sales Management also needs to notify partners about the material revisions and updates.",
                },
                new ContentEntity()
                {
                    Text = "How can Sales Management achieve these goals in Salesforce?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Enable Content in the Partner Community and enable Content email alerts for partner users.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Enable the Document tab in the Partner Community and enable email alerts for partner users.",                    
                },
                new AnswerEntity()
                {
                    Text = "Add the Content related list to the partner contact page layout and enable content delivery.",                    
                },
                new AnswerEntity()
                {
                    Text = "Add the Content related list to the partner account page layout and enable content delivery.",
                },
            }
        };
    }
}