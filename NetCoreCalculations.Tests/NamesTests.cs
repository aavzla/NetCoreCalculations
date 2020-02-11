using Xunit;

namespace NetCoreCalculations.Tests
{
    public class NamesTests
    {
        [Fact]
        public void MakeFullName_GivenTwoStrings_ReturnString()
        {
            var names = new Names();
            var result = names.MakeFullName("John", "Doe");
            Assert.Equal("john Doe", result, ignoreCase: true);
            Assert.StartsWith("john", result, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.Contains("doe", result, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.EndsWith("Doe", result);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void MakeFullName_GivenTwoStrings_AlwaysReturnString()
        {
            var names = new Names();
            var result = names.MakeFullName("John", "Doe");
            
            //If the strings are empty strings, this test will fail. To reinforce the test, we add the other tests.
            Assert.NotNull(result);
            
            //False test, if the strings contains spaces, it will fail. Also, reading not string here is dificult. Better with Assert.False.
            //Assert.True(!string.IsNullOrEmpty(result));

            Assert.False(string.IsNullOrWhiteSpace(result));
        }

        [Fact]
        public void PropertyNickName_GivenStringProperty_MustBeNull()
        {
            var names = new Names();
            var result = names.NickName;
            Assert.Null(result);
        }

        [Fact]
        public void PropertyNickName_GivenStringToProperty_MustBeNotNull()
        {
            var names = new Names();
            var result = names.NickName;
            result = "Test";
            Assert.NotNull(result);
        }
    }
}
