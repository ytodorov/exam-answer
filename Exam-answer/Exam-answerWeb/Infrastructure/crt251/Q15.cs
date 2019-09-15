using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q15
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 15,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers wants to associate some contacts with more than one account (e.g., a contact in an employee of one account and on the boards of several other accounts).",
                },
                new ContentEntity()
                {
                    Text = "Which solution should a consultant recommend to meet this requirement? "
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Enable contacts to multiple accounts feature.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Clone the contact record and add it to the second account.",                    
                },
                new AnswerEntity()
                {
                    Text = "Add the contact to the partners related list on the second account.",                   
                },
                new AnswerEntity()
                {
                    Text = "Associate the contact to other accounts using a custom lookup field.",
                },
            }
        };
    }
}