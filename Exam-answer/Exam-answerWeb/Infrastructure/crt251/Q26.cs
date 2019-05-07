using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q26
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "The Universal Containers credit department uses a third-party application for credit ratings.",
                },
                new ContentEntity()
                {
                    Text = "Credit department man- agers need to launch an external web-based credit application from a customer's account record in Salesforce."
                },
                new ContentEntity()
                {
                    Text = "The application uses a credit ID on the account object."
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to meet this requirement?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a workflow rule to launch the product fulfillment application and pass the credit ID.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a custom button that calls an Apex trigger to launch the credit application and pass the credit ID.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a formula field that uses the hyperlink function to launch the credit application and pass the credit ID.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a custom credit ID field as an external ID on the account to launch the credit application and pass the credit ID.",                    
                },
            }
        };
    }
}