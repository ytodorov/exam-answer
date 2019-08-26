
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q35Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 44,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by *** text to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "Your company implements Azure policies to automatically add a watermark to Microsoft Word documents that contain credit card information.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the underlined text. If it makes the statement correct, select “No change is needed”. If the statement is incorrect, select the answer choice that.",
                },
                new ContentEntity()
                {
                    Text = "Makes the statement correct.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "No change is needed.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "DDoS protection.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Azure Information Protection.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Azure Active Directory (Azure AD) Identity Protection.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/information-protection/infoprotect-quick-start-tutorial",
                },
            },           
        };
    }
}
