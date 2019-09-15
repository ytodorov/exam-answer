using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q26Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 35,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "If a resource group named RG1 has a delete lock, *** ONLY A MEMBER OF THE GLOBAL ADMINISTRATORS GROUP *** can delete RG1.",
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
                    Text = "The delete lock must be removed before an administrator.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "An Azure policy must be modified before an administrator.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "An Azure tag must be added before an administrator.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Lock resources to prevent unexpected changes!"
                },
                new ExplanationEntity()
                {
                    Text = "As an administrator, you may need to lock a subscription, resource group, or resource to prevent other users in your organization from accidentally deleting or modifying critical resources. You can set the lock level to CanNotDelete or ReadOnly. In the portal, the locks are called Delete and Read-only respectively."
                },
                new ExplanationEntity()
                {
                    Text = "CanNotDelete means authorized users can still read and modify a resource, but they can't delete the resource."
                },
                new ExplanationEntity()
                {
                    Text = "ReadOnly means authorized users can read a resource, but they can't delete or update the resource. Applying this lock is similar to restricting all authorized users to the permissions granted by the Reader role."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "How to Lock Azure Resources to Prevent Modification or Deletion",
                    Url = "https://techcommunity.microsoft.com/t5/ITOps-Talk-Blog/How-to-Lock-Azure-Resources-to-Prevent-Modification-or-Deletion/ba-p/356945"
                },
                new ReferenceEntity()
                {
                    Text = "Lock resources",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-lock-resources"
                },
            },
        };
    }
}