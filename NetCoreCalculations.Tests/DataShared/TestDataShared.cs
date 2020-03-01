using System.Collections.Generic;
using System.Linq;

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

        public static IEnumerable<object[]> IsOddOrEvenNumbersExternalData
        {
            get
            {
                var allLines = System.IO.File.ReadAllLines(System.IO.Directory.GetCurrentDirectory() + "/DataShared/IsOddOrEvenTestData.txt");
                return allLines.Select(x =>
                {
                    var lineSplit = x.Split(',');
                    return new object[] { int.Parse(lineSplit[0]), bool.Parse(lineSplit[1]) };
                });
            }
        }
    }
}
