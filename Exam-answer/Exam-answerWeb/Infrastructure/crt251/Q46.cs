using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q46
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters wants to link contacts with more than one account.",
                },
                new ContentEntity()
                {
                    Text = "What solution should be recommended if a contact is an employee in one account, and on the I additional accounts?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Enable contacts to multiple accounts feature.",
                },
                new AnswerEntity()
                {
                    Text = "Associate the contact to other accounts using a custom lookup field.",                    
                },
                new AnswerEntity()
                {
                    Text = "Clone the contact record and add it to the second account.",                    
                },
                new AnswerEntity()
                {
                    Text = "Add the contact to the partners related list on the second account.",
                    IsCorrect = true
                },
            }
        };
    }
}