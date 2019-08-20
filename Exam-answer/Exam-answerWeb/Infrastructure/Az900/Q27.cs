using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q27Instance = new QuestionEntity()
        {
            Order = 27,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "",
                },
                new ContentEntity()
                {
                    Text = ""
                },
                new ContentEntity()
                {
                    Text = ""
                },
                new ContentEntity()
                {
                    Text = ""
                }
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "",
                },
                new AnswerEntity()
                {
                    Text = ""
                },
                new AnswerEntity()
                {
                    Text = "",
                },
                new AnswerEntity()
                {
                    Text = ""
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
                     Url = "",
                },
                new ReferenceEntity()
                {
                     Text = "",
                     Url = "",
                },
                new ReferenceEntity()
                {
                     Text = "",
                     Url = "",
                },
                new ReferenceEntity()
                {
                     Text = "",
                     Url = "",
                },
            }
        };
    }
}