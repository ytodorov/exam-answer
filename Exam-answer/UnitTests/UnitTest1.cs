using DAL.Entities;
using Exam_answerWeb.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //DbContextOptions<ExamAnswerContext> options = new DbContextOptions<ExamAnswerContext>();
           
            //using (ExamAnswerContext context = new ExamAnswerContext(options))
            //{
                
            //}
            //ExamEntity examEntity = examAnswerContext.Exams
            //   .Where(e => e.Provider.Equals(provider, StringComparison.InvariantCultureIgnoreCase) &&
            //       e.Code.Equals(examCode, StringComparison.InvariantCultureIgnoreCase))

            //   .Include(e => e.Questions)
            //   .ThenInclude(q => q.Contents)

            //   .Include(e => e.Questions)
            //   .ThenInclude(q => q.Answers)

            //   .Include(e => e.Questions)
            //   .ThenInclude(q => q.Explanations)

            //   .Include(e => e.Questions)
            //   .ThenInclude(q => q.References)

            //   .AsNoTracking()

            //   .FirstOrDefault();

            //var examViewModel = mapper.Map<ExamViewModel>(examEntity);

            var res = LevenshteinDistance.CalculateSimilarity(@"
 Universal Containers’ current solution for managing its forecasts is cumbersome.

The sales managers do NOT have visibility into their teams’ forecasts and are NOT able to update the forecasts. ",


@" As a result, the managers are continually asking their sales representatives to provide updated forecast data via email or phone.

Which two solutions should a consultant recommend to help Universal Containers improve the management of their forecasts? (Choose two.) ");
        }
    }
}
