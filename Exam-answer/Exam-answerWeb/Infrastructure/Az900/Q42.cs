
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q41Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 52,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "You have several virtual machines in an Azure subscription. You create a new subscription. *** THE VIRTUAL MACHINES CANNOT BE MOVED TO THE NEW SUBSCRIPTION ***.",
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
                    Text = "The virtual machines can be moved to the new subscription.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "The virtual machines can be moved to the new subscription only if they are all in the same resource group.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The virtual machines can be moved to the new subscription only if they run Windows Server 2016.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="",
                    Url = ""
                },
                new ReferenceEntity()
                {
                    Text ="",
                    Url = ""
                }
            },                
        };
    }
}
