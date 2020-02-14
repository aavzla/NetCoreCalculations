using NetCoreCalculations.Tests.Fixtures;
using Xunit;

namespace NetCoreCalculations.Tests
{
    [Collection("Customer")]
    public class CustomerCalculatedTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerCalculatedTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void GetFullName_GivenTwoStrings_ReturnOneString()
        {
            var customer = _customerFixture.Customer;
            Assert.Equal("John Doe", customer.GetFullName("John", "Doe"));
        }
    }
}
