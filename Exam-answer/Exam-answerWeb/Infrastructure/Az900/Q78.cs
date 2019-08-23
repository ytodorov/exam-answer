
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q77Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 202,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You create an Azure Storage account named contosostorage.",
                },
                new ContentEntity()
                {
                    Text = "You plan to create a file share named data.",
                },
                new ContentEntity()
                {
                    Text = "Users need to map a drive to the data file share from home computers that run Windows 10.",
                },
                new ContentEntity()
                {
                    Text = "Which outbound port should you open between the home computers and the data file share?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "80.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "443.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "445.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "3389.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Ensure port 445 is open: The SMB protocol requires TCP port 445 to be open; connections will fail if port 445 is blocked."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/storage/files/storage-how-to-use-files-windows",
                },
            },           
        };
    }
}
