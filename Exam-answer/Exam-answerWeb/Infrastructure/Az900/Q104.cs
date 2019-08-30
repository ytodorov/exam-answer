
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q103Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 239,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have a public load balancer that balances ports 80 and 443 across three virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "You need to direct all the Remote Desktop Protocol (RDP) connections to VM3 only.",
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
                    Text = "An inbound NAT rule.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "A load balancing rule.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A new public load balancer for VM3.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "A frontend IP configuration.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
                new ExplanationEntity()
                {

                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/load-balancer/tutorial-load-balancer-port-forwarding-portal",
                },
                new ReferenceEntity()
                {
                    Url = "https://pixelrobots.co.uk/2017/08/azure-load-balancer-for-rds/",
                },
            },           
        };
    }
}
