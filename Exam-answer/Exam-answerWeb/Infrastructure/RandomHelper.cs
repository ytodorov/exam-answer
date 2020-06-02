using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Infrastructure
{
    public static class RandomHelper
    {
        static RandomHelper()
        {
            Instance = new Random();
        }

        public static Random Instance { get; }

        public static int GetRandomIntValue(List<int> valuesToChooseFrom)
        {
            int randomInt = Instance.Next(0, valuesToChooseFrom.Count);

            int randomT = valuesToChooseFrom[randomInt];

            return randomT;
        }

        public static List<int> GetRandomIntValues(int maxValue, int count)
        {
            if (count > maxValue)
            {
                throw new Exception("count should be less than maxValue");
            }
            List<int> result = new List<int>();

            while (true)
            {
                int randomInt = Instance.Next(0, maxValue) - 1;
                if (!result.Contains(randomInt))
                {
                    result.Add(randomInt);
                }
                if (result.Count == count)
                {
                    return result;
                }
            }
        }
    }
}
