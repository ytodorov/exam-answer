using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public partial class Az100
    {
        public static QuestionEntity Q1Instance = new QuestionEntity()
        {
            Order = 1,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure subscription named Sub1. Sub1 contains two resource groups named RG1 and RG2.",
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that Global Administrators can manage all resources contained in RG1 and RG2."
                },
                new ContentEntity()
                {
                    Text = "Solution: From the Azure Active Directory Properties blade, you enable Access management for Azure resources."
                },
                new ContentEntity()
                {
                    Text = "Does this solution meet the goal?"
                }
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "No"
                },
            }
        };
    }
}