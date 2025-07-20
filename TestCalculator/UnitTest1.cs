using Xunit;
using Calculator;

namespace TestCalculator
{
    public class CalculateurTests
    {
        [Fact]
        public void Addition_DeuxEntiers_RetourneSomme()
        {
            int a = 1;
            int b = 5;

            int result = Calculator.Calculator.Addition(a, b);
        }
    }
}