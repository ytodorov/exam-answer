using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q59
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 59,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Northern Trail Outfitters has two products that each have a unique sales methodology.",
                },
                new ContentEntity()
                {
                    Text = "Some of the sales stages are shared between methodologies; the rest are exclusive to only one of the sales processes.",
                },
                new ContentEntity()
                {
                    Text = "Which three components should be configured to support two unique selling methodologies, even when a few of the sales stages overlap between the two?",
                },
                new ContentEntity()
                {
                    Text = "Choose 3 answers.",
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "One set of opportunity stages.",
                },
                new AnswerEntity()
                {
                    Text = "Two sets of opportunity stages.",                    
                },
                new AnswerEntity()
                {
                    Text = "Two record types",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Two page layouts.",
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "Two sales processes.",
                    IsCorrect = true
                },
            }
        };
    }
}