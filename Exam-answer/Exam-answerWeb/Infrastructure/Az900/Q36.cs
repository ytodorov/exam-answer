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
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "Your company implements *** AZURE POLICIES *** to automatically add a watermark to Microsoft Word documents that contain credit card information.",
                },
                new ContentEntity()
                {
                    Text = "Instructions: Review the UPPER-CASED text surrounded by ***. If it makes the statement correct, select \"No change is needed\". If the statement is incorrect, select the answer choice that makes the statement correct.",
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
                new ExplanationEntity()
                {
                    Text = "An Azure Information Protection policy contains the following elements that you can configure:"
                },
                new ExplanationEntity()
                {
                    Text = "* Which labels are included that let administrators and users classify (and optionally, protect) documents and emails."
                },
                new ExplanationEntity()
                {
                    Text = "* Title and tooltip for the Information Protection bar that users see in their Office applications."
                },
               new ExplanationEntity()
                {
                    Text = "* The option to set a default label as a starting point for classifying documents and emails."
                },
                new ExplanationEntity()
                {
                    Text = "* The option to enforce classification when users save documents and send emails."
                },
                new ExplanationEntity()
                {
                    Text = "* The option to prompt users to provide a reason when they select a label that has a lower sensitivity level than the original."
                },
               new ExplanationEntity()
                {
                    Text = "* The option to automatically label an email message, based on its attachments."
                },
                new ExplanationEntity()
                {
                    Text = "* The option to control whether the Information Protection bar is displayed in Office applications."
                },
                new ExplanationEntity()
                {
                    Text = "* The option to control whether the Do Not Forward button is displayed in Outlook."
                },
               new ExplanationEntity()
                {
                    Text = "* The option to let users specify their own permissions for documents."
                },
                new ExplanationEntity()
                {
                    Text = "* The option to provide a custom help link for users."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Configuring visual markings in Azure Information Protection",
                    Url = "https://alberthoitingh.com/2018/01/05/configuring-visual-markings-in-azure-information-protection/"
                },
                new ReferenceEntity()
                {
                    Text = "Tutorial: Configure Azure Information Protection policy settings and create a new label",
                    Url = "https://docs.microsoft.com/en-us/azure/information-protection/infoprotect-quick-start-tutorial",
                },
            },
        };
    }
}