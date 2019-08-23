
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q70Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 192,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Subscription1. Subscription1 contains the resource groups in the following table.",
                },
                new ContentEntity()
                {
                    Text = "RG1 has a web app named WebApp1. WebApp1 is located in West Europe.",
                },
                new ContentEntity()
                {
                    Text = "You move WebApp1 to RG2.",
                },
                new ContentEntity()
                {
                    Text = "What is the effect of the move?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The App Service plan for WebApp1 moves to North Europe. Policy2 applies to WebApp1.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The App Service plan for WebApp1 remains in West Europe. Policy2 applies to WebApp1.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "The App Service plan for WebApp1 moves to North Europe. Policy1 applies to WebApp1.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The App Service plan for WebApp1 remains in West Europe. Policy1 applies to WebApp1.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You can move an app to another App Service plan, as long as the source plan and the target plan are in the same resource group and geographical region."
                },
                new ExplanationEntity()
                {
                    Text = "The region in which your app runs is the region of the App Service plan it's in. However, you cannot change an App Service plan's region."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/app-service/app-service-plan-manage",
                },
            },           
        };
    }
}
