
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q23Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 32,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You need to configure an Azure solution that meets the following requirements:.",
                },
                new ContentEntity()
                {
                    Text = "Secures websites from attacks.",
                },
                new ContentEntity()
                {
                    Text = "Generates reports that contain details of attempted attacks.",
                },
                new ContentEntity()
                {
                    Text = "What should you include in the solution?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Azure Firewall.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A network security group (NSG).", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Information Protection.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "DDoS protection.", 
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
