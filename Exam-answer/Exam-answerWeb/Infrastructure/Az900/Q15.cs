
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q14Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 20,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by *** text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "You plan to deploy 20 virtual machines to an Azure environment. To ensure that a virtual machine named VM1 cannot connect to the other virtual machines, VM1 must *** BE DEPLOYED TO A SEPARATE VIRTUAL NETWORK ***.",
                },
                new ContentEntity()
                {
                    Text = "Must be deployed to a separate virtual network.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select “No change is needed”. If the statement is incorrect, select the answer choice that.",
                },
                new ContentEntity()
                {
                    Text = "Makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Run a different operating system than the other virtual machines.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Be deployed to a separate resource group.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Have two network interfaces.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
            },           
        };
    }
}
