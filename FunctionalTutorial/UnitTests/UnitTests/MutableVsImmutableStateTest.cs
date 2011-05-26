using Xunit;

namespace CSharpExamples
{
    public class MutableVsImmutableStateTest
    {
        [Fact]
        public void TestMutableFactorial()
        {
            Assert.Equal(1, MutableVsImmutableState.CalculateFactorial(0));
            Assert.Equal(1, MutableVsImmutableState.CalculateFactorial(1));
            Assert.Equal(2, MutableVsImmutableState.CalculateFactorial(2));
            Assert.Equal(6, MutableVsImmutableState.CalculateFactorial(3));
            Assert.Equal(720, MutableVsImmutableState.CalculateFactorial(6));
        }

        [Fact]
        public void TestFunctionalFactorial()
        {
            Assert.Equal(1, MutableVsImmutableState.CalculateFuncFactorial(0));
            Assert.Equal(1, MutableVsImmutableState.CalculateFuncFactorial(1));
            Assert.Equal(2, MutableVsImmutableState.CalculateFuncFactorial(2));
            Assert.Equal(6, MutableVsImmutableState.CalculateFuncFactorial(3));
            Assert.Equal(720, MutableVsImmutableState.CalculateFuncFactorial(6));
        }
    }
}
