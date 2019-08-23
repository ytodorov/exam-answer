
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q95Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 228,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have the Azure virtual networks shown in the following table.",
                },
                new ContentEntity()
                {
                    Text = "To which virtual networks can you establish a peering connection from VNet1?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "VNet2 and VNet3 only.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "VNet2 only.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "VNet3 and VNet4 only.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "VNet2, VNet3, and VNet4.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/tutorial-connect-virtual-networks-portal",
                },
            },           
        };
    }
}
