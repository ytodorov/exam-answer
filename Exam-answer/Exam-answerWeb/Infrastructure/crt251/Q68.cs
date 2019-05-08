using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q68
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Order = 68,
            QuestionType = QuestionType.CheckBox,
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Which three actions should a consultant recommend to provide alignment between a new formal sales methodology and Salesforce?",
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
                    Text = "Override Salesforce user interface with the sales methodology user interface.",
                },
                new AnswerEntity()
                {
                    Text = "Consider available sales methodology AppExchange applications.",                    
                },
                new AnswerEntity()
                {
                    Text = "Develop a data integration between Salesforce and the sales methodology database.",                    
                },
                new AnswerEntity()
                {
                    Text = "Configure Salesforce standard and custom objects to support the sales methodology.",
                },
                new AnswerEntity()
                {
                    Text = "Embed Lightning components within Salesforce to support the sales methodology.",
                },                
            }
        };
    }
}