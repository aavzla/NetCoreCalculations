using System;

namespace NetCoreCalculations
{
    public class Customer
    {
        public string Name => "John";
        public int Age => 43;
        public int OrdersQty => 100;

        public virtual int GetOrdersByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The value submitted was null, string empty or only white spaces", nameof(name));
            }
            if (Name.Equals(name))
            {
                return OrdersQty;
            }
            return 0;
        }

        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
