using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q51
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 51,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "The sales management team of Universal Containers has noticed that opportunities are taking longer to close.",
                },
                new ContentEntity()
                {
                    Text = "Historically, it has taken 30 days for a new opportunity to be moved to closed/won.",
                },
                new ContentEntity()
                {
                    Text = "Recently, this time period has increased to 45 days.",
                },
                new ContentEntity()
                {
                    Text = "What analytics tool can the sales management team leverage to help determine the cause? (Choose 2 answers)",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Dashboard of opportunity stage duration.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Report on campaign return on investment (ROI).",
                },
                new AnswerEntity()
                {
                    Text = "Dashboard of Month-over- month trend of lead conversions.",
                },
                new AnswerEntity()
                {
                    Text = "Report on the discount approval time for quotes",
                    IsCorrect = true
                },
            }
        };
    }
}