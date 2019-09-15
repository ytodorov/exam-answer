using Exam_answerWeb.Infrastructure;

namespace Exam_answerWeb.Extensions
{
    public static class StringExtensions
    {
        public static string PadRightEA(this string stringToPadRight, int totalWidth = 30, char paddingChar = Constants.PaddingChar)
        {
            string result = stringToPadRight.PadRight(totalWidth, paddingChar);
            return result;
        }
    }
}