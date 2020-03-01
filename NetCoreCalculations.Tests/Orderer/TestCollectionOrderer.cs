using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace NetCoreCalculations.Tests.Orderer
{
    public class TestCollectionOrderer : ITestCollectionOrderer
    {
        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {
            return testCollections.OrderBy(x => x.DisplayName);
        }
    }
}
