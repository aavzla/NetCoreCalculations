using Xunit;

namespace NetCoreCalculations.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void CheckNameNotNullOrEmptyOrWhiteSpaces()
        {
            var customer = new Customer();
            Assert.False(string.IsNullOrWhiteSpace(customer.Name));
        }

        [Fact]
        //Case: Insurance company give discount if the customer age is between 25 and 45.
        public void CheckLegitForDiscount()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age, 25, 45);
        }
    }
}
