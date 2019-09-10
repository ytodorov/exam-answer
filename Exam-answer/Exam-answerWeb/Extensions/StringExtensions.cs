using Exam_answerWeb.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Extensions
{
    public static class StringExtensions
    {
        public static string PadRightEA(this string stringToPadRight, int totalWidth = 30, char paddingChar = StringConstants.PaddingChar)
        {
            string result = stringToPadRight.PadRight(totalWidth, paddingChar);
            return result;
        }
    }
}
