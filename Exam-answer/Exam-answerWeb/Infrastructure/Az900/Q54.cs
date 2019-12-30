using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q54Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 54,
            Section = "Understand Cloud Concepts",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "An organization that hosts its infrastructure *** IN A PRIVATE CLOUD *** can decommission its data center.",
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
                    Text = "In a hybrid cloud.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "In the public cloud.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "On a Hyper-V host.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "After a workload is promoted to production, the assets that previously hosted the production workload are no longer required to support business operations. At that point, the older assets are considered retired. Retired assets can then be decommissioned, reducing operational costs. Decommissioning a resource can be as simple as turning off the power to the asset and disposing of the asset responsibly. Unfortunately, decommissioning resources can sometimes have undesired consequences. The following guidance can aid in properly decommissioning retired resources, with minimal business interruptions."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Decommission retired assets",
                    Url = "https://docs.microsoft.com/en-us/azure/architecture/cloud-adoption/migrate/migration-considerations/optimize/decommission"
                },
            },
        };
    }
}