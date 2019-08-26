
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q37Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 46,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "You have an Azure virtual network named VNET1 in a resource group named RG1.",
                },
                new ContentEntity()
                {
                    Text = "You assign an Azure policy specifying that virtual networks are not an allowed resource type in RG1. VNET1 *** IS DELETED AUTOMATICALLY ***.",
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
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Is moved automatically to another resource group.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Continues to function normally.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Is now a read-only object.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/governance/policy/overview",
                },
            },           
        };
    }
}
