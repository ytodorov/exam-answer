
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q21Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 30,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to move several servers to Azure.",
                },
                new ContentEntity()
                {
                    Text = "The company’s compliance policy states that a server named FinServer must be on a separate network segment.",
                },
                new ContentEntity()
                {
                    Text = "You are evaluating which Azure services can be used to meet the compliance policy requirements.",
                },
                new ContentEntity()
                {
                    Text = "Which Azure solution should you recommend?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A resource group for FinServer and another resource group for all the other servers.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A virtual network for FinServer and another virtual network for all the other servers.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A VPN for FinServer and a virtual network gateway for each other server.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "One resource group for all the servers and a resource lock for FinServer.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = ""
                },
                new ExplanationEntity()
                {
                    Text = ""
                },
                new ExplanationEntity()
                {
                    Text = ""
                },
                new ExplanationEntity()
                {
                    Text = ""
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-vnet-plan-design-arm",
                },
            },           
        };
    }
}
