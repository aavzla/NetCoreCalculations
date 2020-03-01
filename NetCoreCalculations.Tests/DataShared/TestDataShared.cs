using System.Collections.Generic;

namespace NetCoreCalculations.Tests.DataShared
{
    public static class TestDataShared
    {
        public static IEnumerable<object[]> IsOddOrEvenNumbers
        {
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 200, false };
            }
        }
    }
}
