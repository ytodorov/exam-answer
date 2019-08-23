
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q7Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 11,
            Section = "Understand Core Azure Services",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You plan to map a network drive from several computers that run Windows 10 to Azure Storage. You need to create a storage solution in Azure for the planned.",
                },
                new ContentEntity()
                {
                    Text = "Mapped drive.",
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
                    Text = "An Azure SQL database.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A virtual machine data disk.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A Files service in a storage account.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A Blobs service in a storage account.", 
                    IsCorrect = false
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
