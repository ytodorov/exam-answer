
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q40Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 51,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "Your Azure trial account expired last week. You are now unable to *** CREATE ADDITIONAL AZURE ACTIVE DIRECTORY (AZURE AD) USER ACCOUNTS ***.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Start an existing Azure virtual machine.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Access your data stored in Azure.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Access the Azure portal.", 
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
