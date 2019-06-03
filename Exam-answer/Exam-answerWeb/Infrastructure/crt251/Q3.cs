using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q3
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 3,
            QuestionType = QuestionType.RadioButon,
            Contents = new List<ContentEntity>()
                    {
                        new ContentEntity()
                        {
                            Text = "The members of an opportunity team at Universal Containers are working together to close an opportunity.",
                        },
                        new ContentEntity()
                        {
                            Text = "The sales engineer on the team is having trouble keeping up with the active quote."
                        },
                        new ContentEntity()
                        {
                            Text = "How can the sales engineer identify the opportunity's active quote?"
                        },
                    },
            Answers = new List<AnswerEntity>()
                    {
                        new AnswerEntity()
                        {
                            Text = "Reference the last modified date on the quotes.",
                        },
                        new AnswerEntity()
                        {
                            Text = "Reference the synced quote field on the opportunity record.",
                            IsCorrect = true
                        },
                        new AnswerEntity()
                        {
                            Text = "Reference synced quote history on the opportunity.",
                        },
                        new AnswerEntity()
                        {
                            Text = "Follow the opportunities' quotes in Chatter.",
                        },
                    }
        };
    }
}