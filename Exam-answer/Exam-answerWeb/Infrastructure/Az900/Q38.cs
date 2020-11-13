using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q38Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 38,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "This question requires that you evaluate the UPPER-CASED text surrounded by ***  to determine if it is correct.",
                },
                new ContentEntity()
                {
                    Text = "You have an Azure virtual network named VNET1 in a resource group named RG1.",
                },
                new ContentEntity()
                {
                    Text = "You assign an Azure policy specifying that virtual networks are not an allowed resource type in RG1. VNET1 *** IS DELETED AUTOMATICALLY ***.",
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
                    Text = "Is moved automatically to another resource group.",
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Continues to function normally.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Is now a read-only object.",
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "The journey of creating and implementing a policy in Azure Policy begins with creating a policy definition. Every policy definition has conditions under which it's enforced. And, it has a defined effect that takes place if the conditions are met."
                },
                new ExplanationEntity()
                {
                    Text = "In Azure Policy, we offer several built-in policies that are available by default. For example:"
                },
                new ExplanationEntity()
                {
                    Text = "Allowed Resource Type: Defines the resource types that you can deploy. Its effect is to deny all resources that aren't part of this defined list."
                },
                new ExplanationEntity()
                {
                    Text = "Not allowed resource types: Prevents a list of resource types from being deployed."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Text = "Sample - Not allowed resource types",
                    Url = "https://docs.microsoft.com/en-us/azure/governance/policy/samples/not-allowed-resource-types"
                },
                new ReferenceEntity()
                {
                    Text = "Overview of the Azure Policy service",
                    Url = "https://docs.microsoft.com/en-us/azure/governance/policy/overview",
                },
            },
        };
    }
}