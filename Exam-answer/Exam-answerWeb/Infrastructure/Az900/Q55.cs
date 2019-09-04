
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q54Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 153,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "When you are implementing a software as a service (SaaS) solution, you are responsible for *** CONFIGURING HIGH AVAILABILITY ***.",
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
                    Text = "Defining scalability rules.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Installing the SaaS solution.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Configuring the SaaS solution.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Software as a service (SaaS) allows users to connect to and use cloud-based apps over the Internet. Common examples are email, calendaring, and office tools (such as Microsoft Office 365)."
                },
                new ExplanationEntity()
                {
                    Text = "SaaS provides a complete software solution that you purchase on a pay-as-you-go basis from a cloud service provider. You rent the use of an app for your organization, and your users connect to it over the Internet, usually with a web browser. All of the underlying infrastructure, middleware, app software, and app data are located in the service provider’s data center. The service provider manages the hardware and software, and with the appropriate service agreement, will ensure the availability and the security of the app and your data as well. SaaS allows your organization to get quickly up and running with an app at minimal upfront cost."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="What is SaaS?",
                    Url = "https://azure.microsoft.com/en-us/overview/what-is-saas/"
                },
            },                
        };
    }
}
