
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q94Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 227,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have five Azure virtual machines that run Windows Server 2016. The virtual machines are configured as web servers.",
                },
                new ContentEntity()
                {
                    Text = "You have an Azure load balancer named LB1 that provides load balancing services for the virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that visitors are serviced by the same web server for each request.",
                },
                new ContentEntity()
                {
                    Text = "What should you configure?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Protocol to UDP.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Session persistence to None.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Session persistence to Client IP.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Idle Time-out (minutes) to 20.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "You can set the sticky session in load balancer rules with setting the session persistence as the client IP."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Configure Azure Load Balancer For Sticky Sessions",
                    Url = "https://cloudopszone.com/configure-azure-load-balancer-for-sticky-sessions/",
                },
            },           
        };
    }
}
