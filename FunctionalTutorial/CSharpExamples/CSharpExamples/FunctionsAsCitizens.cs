using System;

namespace CSharpExamples
{
    public enum FunctionType
    {
        Combine,
        Lambda,
   }

    public class FunctionsAsCitizens
    {
        public Func<int, int, int> GetFunctionOfType(FunctionType type)
        {
            // won't compile
            // var func2 = Combine;
            switch (type)
            {
                case FunctionType.Combine:
                    return Combine;
                case FunctionType.Lambda:
                    return (a, b) => a*b;
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }

        private static int Combine(int a, int b)
        {
            return a + b;
        }
    }
}