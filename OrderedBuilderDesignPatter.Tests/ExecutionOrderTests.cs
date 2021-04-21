using ConditionalBuilderDesignPattern;
using Xunit;

namespace OrderedBuilderDesignPatter.Tests
{
    public class ExecutionOrderTests
    {
        [Theory]
        [InlineData(0, ExecutionOrder.WithKatanas)]
        [InlineData(1, ExecutionOrder.WithEntries)]
        [InlineData(2, ExecutionOrder.WithLevel)]
        [InlineData(3, ExecutionOrder.WithName)]
        [InlineData(4, ExecutionOrder.WithRank)]
        public void ExecutionOrder_Should_Have_Specific_Order(int expectedOrder, ExecutionOrder executionOrder)
        {
            Assert.Equal(expectedOrder, (int)executionOrder);
        }

    }
}
