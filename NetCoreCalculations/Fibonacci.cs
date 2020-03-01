using System.Collections.Generic;

namespace NetCoreCalculations
{
    public class Fibonacci
    {
        public List<int> FiboNumbers => new List<int>() { 1, 1, 2, 3, 5, 8, 13 };

        public bool IsOddValue(int value)
        {
            //If the result is zero, it is a even number, if it is not is an Odd number.
            return (value % 2) == 1;
        }

        public bool Is1Number(int value)
        {
            if (value == 1)
            {
                return true;
            }
            return false;
        }
    }
}
