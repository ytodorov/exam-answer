using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Az900
{
    public partial class Az900
    {
        public static QuestionEntity Q12Instance = new QuestionEntity()
        {
            Order = 12,
            Section = "Understand Security, Privacy, Compliance and Trust",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Note: This question is part of a series of questions that present the same scenario. Each question in the series contains a unique solution that might meet the stated goals. Some question sets might have more than one correct solution, while others might not have a correct solution.",
                },
                new ContentEntity()
                {
                    Text = "After you answer a question in this section, you will NOT be able to return to it. As a result, these questions will not appear in the review screen"
                },
                new ContentEntity()
                {
                    Text = "Your Azure environment contains multiple Azure virtual machines."
                },
                new ContentEntity()
                {
                    Text = "You need to ensure that a virtual machine named VM1 is accessible from the Internet over HTTP."
                },
                new ContentEntity()
                {
                    Text = "Solution: You modify an Azure firewall."
                },
                new ContentEntity()
                {
                    Text = "Does this meet the goal?"
                }
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Yes.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "No."
                },               
            },
            Explanations = new List<ExplanationEntity>()
            {
               
            },
            References = new List<ReferenceEntity>()
            {
                
            }
        };
    }
}