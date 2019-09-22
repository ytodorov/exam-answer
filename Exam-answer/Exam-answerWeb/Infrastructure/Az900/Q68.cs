using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q67Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 183,
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
                new ExplanationEntity()
                {
                    Text = "Verification methods:"
                },
                new ExplanationEntity()
                {
                    Text = "You can choose the verification methods that are available for your users."
                },
                new ExplanationEntity()
                {
                    Text = "When your users enroll their accounts for Azure Multi-Factor Authentication, they choose their preferred verification method from the options that you have enabled. Guidance for the user enrollment process is provided in Set up my account for two-step verification.",
                },
                new ExplanationEntity()
                {
                    Text = "Call to phone: Places an automated voice call. The user answers the call and presses # in the phone keypad to authenticate. The phone number is not synchronized to on-premises Active Directory.",
                },
                 new ExplanationEntity()
                {
                    Text = "Text message to phone: Sends a text message that contains a verification code. The user is prompted to enter the verification code into the sign-in interface. This process is called one-way SMS. Two-way SMS means that the user must text back a particular code. Two-way SMS is deprecated and not supported after November 14, 2018. Users who are configured for two-way SMS are automatically switched to call to phone verification at that time.",
                },
                new ExplanationEntity()
                {
                    Text = "Notification through mobile app: Sends a push notification to your phone or registered device. The user views the notification and selects Verify to complete verification. The Microsoft Authenticator app is available for Windows Phone, Android, and iOS.",
                },
                 new ExplanationEntity()
                {
                    Text = "Verification code from mobile app or hardware token: The Microsoft Authenticator app generates a new OATH verification code every 30 seconds. The user enters the verification code into the sign-in interface. The Microsoft Authenticator app is available for Windows Phone, Android, and iOS.",
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Configure Azure Multi-Factor Authentication settings",
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/authentication/howto-mfa-mfasettings"
                },
            },
        };
    }
}