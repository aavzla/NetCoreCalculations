using System.Collections.Generic;
using Xunit;

namespace NetCoreCalculations.Tests
{
    public class LoyalCustomerTests
    {
        [Fact]
        public void GetCustomerBasedOnOrderLessOrEqualTo100()
        {
            var customer = CustomerFactory.CreateCustomerInstanceBasedOnOrderQty(80);
            //This shows a warning to not use it, this will return void and can not be extended, means, we can not look into the object built.
            //Assert.IsType(typeof(Customer), customer);
            Assert.IsType<Customer>(customer);
        }

        [Fact]
        public void GetCustomerBasedOnOrderGreaterThan100()
        {
            var customer = CustomerFactory.CreateCustomerInstanceBasedOnOrderQty(120);
            //This shows a warning to not use it, this will return void and can not be extended, means, we can not look into the object built.
            //Assert.IsType(typeof(LoyalCustomer), customer);
            Assert.IsType<LoyalCustomer>(customer);
        }

        [Fact]
        public void GetLoyalCustomerDiscount()
        {
            var customer = CustomerFactory.CreateCustomerInstanceBasedOnOrderQty(110);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.LoyalCustomerDiscount);
        }

        [Fact]
        public void TestTypeList()
        {
            var submittedList = new List<string>() { "test" };
            var expectedList = new List<string>();
            Assert.IsType(expectedList.GetType(), submittedList);
            Assert.IsType<List<string>>(submittedList);
        }
    }
}
