
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q22Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 31,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company has an Azure environment that contains resources in several regions.",
                },
                new ContentEntity()
                {
                    Text = "A company policy states that administrators must only be allowed to create additional Azure resources in a region in the country where their office is located.",
                },
                new ContentEntity()
                {
                    Text = "You need to create the Azure resource that must be used to meet the policy requirement.",
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
                    Text = "A read-only lock.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure policy.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A management group.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A reservation.", 
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
                    Text = "",
                    Url = ""
                },
                new ReferenceEntity()
                {
                    Text = "",
                    Url = ""
                },
            },           
        };
    }
}
