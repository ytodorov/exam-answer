using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q49
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 49,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Resellers for Universal Containers need access to reports in the Partner Communities to help manage their opportunities.",
                },
                new ContentEntity()
                {
                    Text = "How should Salesforce be configured to give resellers the correct level of access to reports?",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Create a chatter group that allows a partner to post item appropriate list view and report.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create the appropriate list views and report folder, and share with all partner users.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Create the opportunity list view and report folder in the partner communities for all partners.",                    
                },
                new AnswerEntity()
                {
                    Text = "Create a new tab in the partner communities to display the appropriate list view and report folder.",                    
                },
            }
        };
    }
}