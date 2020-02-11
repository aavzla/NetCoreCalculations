using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreCalculations
{
    public class LoyalCustomer : Customer
    {
        public int LoyalCustomerDiscount { get; set; }

        public LoyalCustomer()
        {
            LoyalCustomerDiscount = 10;
        }

        public override int GetOrdersByName(string name)
        {
            return 101;
        }
    }
}
