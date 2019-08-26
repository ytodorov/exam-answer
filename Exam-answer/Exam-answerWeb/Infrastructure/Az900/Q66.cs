
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q65Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 178,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Your company plans to migrate all network resources to Azure and to decommission the on-premises data center.",
                },
                new ContentEntity()
                {
                    Text = "You need to recommend a solution to minimize the impact on users after the planned migration.",
                },
                new ContentEntity()
                {
                    Text = "What should you recommend?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Implement Azure Multi-Factor Authentication (MFA).", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Sync all the Active Directory user accounts to Azure Active Directory (Azure AD).", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Instruct all users to change their password.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "Create a guest user account in Azure Active Directory (Azure AD) for each user.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
            },

            References = new List<ReferenceEntity>()
            {
            },           
        };
    }
}