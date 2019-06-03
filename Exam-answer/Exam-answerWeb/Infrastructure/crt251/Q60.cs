using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q60
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 60,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters (NTO) wants to record information about its conferences and the attendees.",
                },
                new ContentEntity()
                {
                    Text = "Some customers attend multiple NTO conferences.",
                },
                 new ContentEntity()
                {
                    Text = "What should the consultant recommend if NTO desires to present this data on the contact layout using the standard configuration?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a custom object for conferences and a custom object to record attendee information.",
                },
                new AnswerEntity()
                {
                    Text = "Utilize Campaigns for conferences and a custom object to record attendee information.",
                },
                new AnswerEntity()
                {
                    Text = "Utilize Campaigns for conferences and add Campaign Members to record attendee information.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create a custom object for conferences and a custom lookup field to conferences on Contacts.",
                },
            }
        };
    }
}