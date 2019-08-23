
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q20Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 28,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure environment that contains multiple Azure virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "You plan to implement a solution that enables the client computers on your on-premises network to communicate to the Azure virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend which Azure resources must be created for the planned solution.",
                },
                new ContentEntity()
                {
                    Text = "Which two Azure resources should you include in the recommendation? Each correct answer presents part of the solution.",
                },
                new ContentEntity()
                {
                    Text = "NOTE: Each correct selection is worth one point.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A virtual network gateway.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A load balancer.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An application gateway.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A virtual network.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A gateway subnet.", 
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
                    Url = "https://docs.microsoft.com/en-us/office365/enterprise/connect-an-on-premises-network-to-a-microsoft-azure-virtual-network",
                },
            },           
        };
    }
}
