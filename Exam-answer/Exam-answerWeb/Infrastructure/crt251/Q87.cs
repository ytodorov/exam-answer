using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q87
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 87,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which method should be used to automate repeat opportunities when regular customers are classified as a repeat account type?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Develop an Apex trigger to set an opportunity revenue schedule that automatically sets up a new opportunity for repeat accounts when it reaches closed/won stage.",
                },
                new AnswerEntity()
                {
                    Text = "Develop an Apex trigger for repeat accounts that inserts a copy of an opportunity for the sales representative when it reaches closed/won stage.",                    
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Configure a workflow rule for repeat accounts that sends a reminder task to the sales representative to create a new opportunity when it reaches closed/won stage.",                    
                },
                new AnswerEntity()
                {
                    Text = "Configure a workflow rule for repeat accounts that inserts a copy of an opportunity for the sales representative when it reaches closed/won stage.",
                },
            }
        };
    }
}