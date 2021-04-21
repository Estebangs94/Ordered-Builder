using ConditionalBuilderDesignPattern;
using Xunit;

namespace OrderedBuilderDesignPatter.Tests
{
    public class DemonSlayerTests
    {
        [Fact]
        public void DemonSlayer_Should_Instantiate_Required_Fields()
        {
            // Arrange & Act
            var target = new DemonSlayer();

            //Assert
            Assert.NotNull(target.Entries);
        }
    }
}
