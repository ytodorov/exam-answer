using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.crt251
{
    public class Q34
    {
        public static QuestionEntity Instance = new QuestionEntity()
        {
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "Universal Containers acquires sales leads each year through trade shows.",
                },
                new ContentEntity()
                {
                    Text = "Occasionally, duplicate leads are generated when the marketing team imports leads that already exist in the system."
                },
                new ContentEntity()
                {
                    Text = "What should a consultant recommend to prevent duplicate leads in the system?"
                },
            },
            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "Upload the leads to Data.com to remove the duplicates and select the option to have them automatically imported.",                    
                },
                new AnswerEntity()
                {
                    Text = "Upload the leads and click the “Find Duplicates” button for each of the leads to identify potential duplicate lead records.",                    
                },
                new AnswerEntity()
                {
                    Text = "Upload the leads using Data Loader and enable the “Find Duplicates” setting to prevent duplicate records.",                   
                },
                new AnswerEntity()
                {
                    Text = "Upload the leads using Data Import Wizard and select the appropriate field to match duplicates against existing records.",
                    IsCorrect = true
                },
            }
        };
    }
}