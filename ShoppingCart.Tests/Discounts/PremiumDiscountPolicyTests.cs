using ShoppingCart.Disounts.Policies;
using FluentAssertions;
using Xunit;

namespace ShoppingCart.Tests.Discounts
{
    public class PremiumDiscountPolicyTests
    {
        [Theory]
        [InlineData(2000, 1800)]     // 10%
        [InlineData(6000, 5100)]     // 15%
        [InlineData(10000, 8000)]    // 20%
        [InlineData(20000, 14000)]   // 30%
        public void PremiumCustomer_Discount_IsCalculatedCorrectly(
            decimal purchaseAmount,
            decimal expectedFinalAmount)
        {
            // Arrange
            var policy = new PremiumDiscountPolicy();

            // Act
            var result = policy.CalculateFinalAmount(purchaseAmount);

            // Assert
            result.Should().Be(expectedFinalAmount);
        }
    }
}





