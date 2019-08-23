
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q59Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 161,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You need to limit the amount of inbound traffic to all the Azure virtual networks.",
                },
                new ContentEntity()
                {
                    Text = "What should you create?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "One network security group (NSG).", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "10 virtual network gateways.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "10 Azure ExpressRoute circuits.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "One Azure firewall.", 
                    IsCorrect = true
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
