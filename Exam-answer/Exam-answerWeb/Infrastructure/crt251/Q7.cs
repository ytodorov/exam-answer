using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q7
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 7,
            QuestionType = QuestionType.RadioButon,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers has a customer base that includes both individual consumers and businesses.",
                },
                new ContentEntity()
                {
                    Text = "The company has implemented Person Accounts in Salesforce and has a custom object for “Policies” that needs to relate to both Person Accounts and business accounts."
                },
                 new ContentEntity()
                {
                    Text = "What is the minimum configuration on the policy custom object needed to meet this requirement?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a contact lookup field and an account lookup field.",
                },
                new AnswerEntity()
                {
                    Text = "Create a master-detail account relationship.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a custom contact lookup field.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a master-detail contact relationship.",
                },
            }
        };
    }
}