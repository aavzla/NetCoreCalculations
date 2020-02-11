namespace NetCoreCalculations
{
    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstanceBasedOnOrderQty(int orderQty)
        {
            if (orderQty <= 100)
            {
                return new Customer();
            }
            else
            {
                return new LoyalCustomer();
            }
        }
    }
}
