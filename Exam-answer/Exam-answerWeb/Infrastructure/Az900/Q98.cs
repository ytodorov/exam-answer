
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q97Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.CheckBox,
            Order = 230,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Subscription1 that contains the resource groups shown in the following table.",
                },
                new ContentEntity()
                {
                    Text = "Name: RG1, Region: East Asia"
                },
                new ContentEntity()
                {
                    Text = "Name: RG2, Region: East US"
                },
                new ContentEntity()
                {
                    Text = "In RG1, you create a virtual machine named VM1 in the East Asia location.",
                },
                new ContentEntity()
                {
                    Text = "You plan to create a virtual network named VNET1.",
                },
                new ContentEntity()
                {
                    Text = "You need to create VNET1, and then connect VM1 to VNET1.",
                },
                new ContentEntity()
                {
                    Text = "What are two possible ways to achieve this goal? Each correct answer presents a complete solution.",
                },
                new ContentEntity()
                {
                    Text = "NOTE: Each correct selection is worth one point.",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create VNET1 in RG2, and then set East Asia as the location.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create VNET1 in a new resource group in the West US location, and then set West US as the location.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create VNET1 in RG1, and then set East US as the location.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create VNET1 in RG2, and then set East US as the location.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create VNET1 in RG1, and then set East Asia as the location.", 
                    IsCorrect = true
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Resource group - A container that holds related resources for an Azure solution. The resource group includes those resources that you want to manage as a group. You decide which resources belong in a resource group based on what makes the most sense for your organization."
                },
                new ExplanationEntity()
                {
                    Text = "There are some important factors to consider when defining your resource group:"
                },
                new ExplanationEntity()
                {
                    Text = "A resource group can contain resources that are located in different regions.",
                },
                new ExplanationEntity()
                {
                    Text = "All the resources in your group should share the same lifecycle. You deploy, update, and delete them together. If one resource, such as a database server, needs to exist on a different deployment cycle it should be in another resource group.",
                },
                new ExplanationEntity()
                {
                    Text = "Each resource can only exist in one resource group.",
                },
                new ExplanationEntity()
                {
                    Text = "You can add or remove a resource to a resource group at any time.",
                },
                new ExplanationEntity()
                {
                    Text = "You can move a resource from one resource group to another group. ",
                },
                new ExplanationEntity()
                {
                    Text = "A resource group can be used to scope access control for administrative actions.",
                },
                new ExplanationEntity()
                {
                    Text = "A resource can interact with resources in other resource groups. This interaction is common when the two resources are related but don't share the same lifecycle (for example, web apps connecting to a database).",
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text ="Azure Resource Manager overview",
                    Url = "https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-overview"
                },
            },                
        };
    }
}
