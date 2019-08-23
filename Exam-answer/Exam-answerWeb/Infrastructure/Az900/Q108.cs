
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q107Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 243,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You set the multi-factor authentication status for a user named admin1@contoso.com to Enabled.",
                },
                new ContentEntity()
                {
                    Text = "Admin1 accesses the Azure portal by using a web browser.",
                },
                new ContentEntity()
                {
                    Text = "Which additional security verifications can Admin1 use when accessing the Azure portal?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "A phone call, a text message that contains a verification code, and a notification or a verification code sent from the Microsoft Authenticator app.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "An app password, a text message that contains a verification code, and a notification sent from the Microsoft Authenticator app.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An app password, a text message that contains a verification code, and a verification code sent from the Microsoft Authenticator app.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A phone call, an email message that contains a verification code, and a text message that contains an app password.", 
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
