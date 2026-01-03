using ShoppingCart.Disounts.Policies;
using FluentAssertions;
using Xunit;

namespace ShoppingCart.Tests.Discounts
{
    public class RegularDiscountPolicyTests
    {
        [Theory]
        [InlineData(4000, 4000)]     // No discount
        [InlineData(5000, 5000)]     // Boundary
        [InlineData(10000, 9000)]    // 10% discount
        [InlineData(15000, 12000)]   // 20% discount
        public void RegularCustomer_Discount_IsCalculatedCorrectly(
            decimal purchaseAmount,
            decimal expectedFinalAmount)
        {
            // Arrange
            var policy = new RegularDiscountPolicy();

            // Act
            var result = policy.CalculateFinalAmount(purchaseAmount);

            // Assert
            result.Should().Be(expectedFinalAmount);
        }
    }
}