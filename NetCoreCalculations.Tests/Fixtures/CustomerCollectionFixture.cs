using Xunit;

namespace NetCoreCalculations.Tests.Fixtures
{
    [CollectionDefinition("Customer")]
    public class CustomerCollectionFixture : ICollectionFixture<CustomerFixture>
    {
    }
}
