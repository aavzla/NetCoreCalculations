using Xunit;

namespace NetCoreCalculations.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_GivenTwoIntegers_ReturnsInteger()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_GivenTwoDoubles_ReturnsDoubles()
        {
            var calc = new Calculator();
            var result = calc.Add(1.23, 3.55);
            Assert.Equal(4.78, result, 2);
        }
    }
}
