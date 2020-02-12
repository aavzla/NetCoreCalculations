using NetCoreCalculations.Tests.Fixtures;
using Xunit;

namespace NetCoreCalculations.Tests
{
    public class CalculatorTests : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _calculatorFixture;

        public CalculatorTests(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Fact]
        public void Add_GivenTwoIntegers_ReturnsInteger()
        {
            var calc = _calculatorFixture.Calculator;
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_GivenTwoDoubles_ReturnsDoubles()
        {
            var calc = _calculatorFixture.Calculator;
            var result = calc.Add(1.23, 3.55);
            Assert.Equal(4.78, result, 2);
        }
    }
}
