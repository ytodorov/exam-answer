using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q7Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 7,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You plan to deploy several Azure virtual machines.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that the services running on the virtual machines are available if a single data center fails.",
                },
                new ContentEntity()
                {
                    Text = "Solution: You deploy the virtual machines to two or more scale sets.",
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "No.",
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Azure virtual machine scale sets let you create and manage a group of identical, load balanced VMs. The number of VM instances can automatically increase or decrease in response to demand or a defined schedule. Scale sets provide high availability to your applications, and allow you to centrally manage, configure, and update a large number of VMs. With virtual machine scale sets, you can build large-scale services for areas such as compute, big data, and container workloads."
                },
                new ExplanationEntity()
                {
                    Text = "To provide redundancy and improved performance, applications are typically distributed across multiple instances. Customers may access your application through a load balancer that distributes requests to one of the application instances. If you need to perform maintenance or update an application instance, your customers must be distributed to another available application instance. To keep up with additional customer demand, you may need to increase the number of application instances that run your application."
                },
                new ExplanationEntity()
                {
                    Text = "A region is a set of datacenters deployed within a latency-defined perimeter and connected through a dedicated regional low-latency network. With more global regions than any other cloud provider, Azure gives customers the flexibility to deploy applications where they need to. Azure is generally available in 46 regions around the world, with plans announced for 8 additional regions."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Azure regions",
                    Url = "https://azure.microsoft.com/en-us/global-infrastructure/regions/",
                },
            },
        };
    }
}