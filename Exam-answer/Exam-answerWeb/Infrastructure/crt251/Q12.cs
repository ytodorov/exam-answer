using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q12
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 12,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers sells products that require frequent collaboration with the same team of individuals who play a key role in closing deals.",
                },
                new ContentEntity()
                {
                    Text = "The lead sales representative determines the level of access for each of the collaborating team members on an opportunity."
                },
                new ContentEntity()
                {
                    Text = "Which solution should a consultant recommend to facilitate the collaboration of the lead sales representative and team members?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create public groups for extended team members and allow the sales representative to assign manual sharing on their opportunities.",
                },
                new AnswerEntity()
                {
                    Text = "Define a sharing rule for each lead sales representative to assign appropriate access for all extended team members.",
                },
                new AnswerEntity()
                {
                    Text = "Configure default opportunity teams for all lead sales representatives with team selling enabled.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Enable Chatter to have the lead sales representative facilitate collaboration through sales team swarming.",
                },
            }
        };
    }
}