
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q44Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 55,
            Section = "Understand Azure Pricing and Support",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to migrate to Azure. The company has several departments. All the Azure resources used by each department will be managed by a.",
                },
                new ContentEntity()
                {
                    Text = "Department administrator.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend an Azure deployment that provides the ability to segment Azure for the departments. The solution must minimize administrative effort.",
                },
                new ContentEntity()
                {
                    Text = "What should you include in the recommendation?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Multiple subscriptions.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Multiple Azure Active Directory (Azure AD) directories.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Multiple regions.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Multiple resource groups.", 
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
