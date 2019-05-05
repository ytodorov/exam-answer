using Exam_answerWeb.Infrastructure;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = LevenshteinDistance.CalculateSimilarity(@"
 Universal Containers’ current solution for managing its forecasts is cumbersome.

The sales managers do NOT have visibility into their teams’ forecasts and are NOT able to update the forecasts. ",


@" As a result, the managers are continually asking their sales representatives to provide updated forecast data via email or phone.

Which two solutions should a consultant recommend to help Universal Containers improve the management of their forecasts? (Choose two.) ");
        }
    }
}
