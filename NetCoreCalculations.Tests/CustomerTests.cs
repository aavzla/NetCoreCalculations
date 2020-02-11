using System;
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

        [Fact]
        public void GetOrdersByNameThrowsArgumentException()
        {
            var customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
            Assert.NotNull(exceptionDetails.Message);
            Assert.NotEmpty(exceptionDetails.Message);
            Assert.NotNull(exceptionDetails.ParamName);
            Assert.NotEmpty(exceptionDetails.ParamName);
        }

        [Fact]
        public void GetOrdersByNameGet100()
        {
            var customer = new Customer();
            Assert.Equal(100, customer.GetOrdersByName(customer.Name));
        }

        [Fact]
        public void GetOrdersByNameGetZero()
        {
            var customer = new Customer();
            Assert.Equal(0, customer.GetOrdersByName("Doe"));
        }
    }
}
