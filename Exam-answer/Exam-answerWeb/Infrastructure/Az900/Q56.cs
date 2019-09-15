using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q55Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 154,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an on-premises network that contains several servers.",
                },
                new ContentEntity()
                {
                    Text = "You plan to migrate all the servers to Azure.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a solution to ensure that some of the servers are available if a single Azure data center goes offline for an extended period.",
                },
                new ContentEntity()
                {
                    Text = "What should you include in the recommendation?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Fault tolerance.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Elasticity.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Scalability.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Low latency.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "A High Availability system is one that is designed to be available 99.999% of the time, or as close to it as possible. Usually this means configuring a failover system that can handle the same workloads as the primary system."
                },
                new ExplanationEntity()
                {
                    Text = "A Fault Tolerant system is extremely similar to HA, but goes one step further by guaranteeing zero downtime. HA still comes with a small portion of downtime, hence the ideal of a perfect HA strategy reaching “five nines” rather than 100% uptime. The time it takes for the intermediary layer, like the load balancer or hypervisor, to detect a problem and restart the VM can add up to minutes or even hours over the course of yearly runtime."
                },
                new ExplanationEntity()
                {
                    Text = "Disaster Recovery goes beyond FT or HA and consists of a complete plan to recover critical business systems and normal operations in the event of a catastrophic disaster like a major weather event (hurricane, flood, tornado, etc), a cyberattack, or any other cause of significant downtime. HA is often a major component of DR, which can also consist of an entirely separate physical infrastructure site with a 1:1 replacement for every critical infrastructure component, or at least as many as required to restore the most essential business functions."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="High Availability vs. Fault Tolerance vs. Disaster Recovery",
                    Url = "https://www.greenhousedata.com/blog/high-availability-vs-fault-tolerance-vs-disaster-recovery"
                },
            },
        };
    }
}