using System;

namespace CSharpExamples
{
    public class MutableVsImmutableState
    {
        public static int CalculateFactorial(int end)
        {
            var result = 1;
            for (var i = 1; i <= end; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int CalculateFuncFactorial(int i)
        {
            return i == 0 ? 1 : i * CalculateFuncFactorial(i - 1);
        }
    }
}