
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q24Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 33,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to migrate all on-premises data to Azure. You need to identify whether Azure complies with the company’s regional requirements.",
                },
                new ContentEntity()
                {
                    Text = "What should you use?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "The Knowledge Center.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Marketplace.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The Azure portal.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "The Trust Center.", 
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
