using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q11
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers wants to capture business sector information on a lead and display the information on the account and contact once the lead has been converted.",
                },
                new ContentEntity()
                {
                    Text = "How can these requirements be met?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a custom field on the Lead, Account, and Contact objects and configure mapping of these two field for conversion. Use a trigger to update the Contact field with the Account value.",                   
                },
                new AnswerEntity()
                {
                    Text = "Create a custom field on the Lead and Account objects. Create a custom formula field on the Contact object to pull the value from the Account object.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a custom field on the Lead and Account objects and configure mapping of these two fields for conversion. Create a custom formula field on the Contact object to pull value form the Account object.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a custom field on the Lead and Account objects and configure mapping of these two fields for conversion. Create a custom formula field on the Account object to pull value form the Contact object.",
                },
            }
        };
    }
}