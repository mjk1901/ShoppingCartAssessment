using FluentAssertions;
using ShoppingCart.Billing;
using ShoppingCart.Disounts.Factory;
using Xunit;

namespace ShoppingCart.Tests.Billing
{
    public class BillingCalculatorTests
    {
        [Fact]
        public void BillingCalculator_UsesCorrectPolicy_ForRegularCustomer()
        {
            // Arrange
            var factory = new DiscountPolicyFactory();
            var calculator = new BillingCalculator(factory);

            // Act
            var finalAmount = calculator.CalculateBill("Regular", 10000);

            // Assert
            finalAmount.Should().Be(9000);
        }

        [Fact]
        public void BillingCalculator_UsesCorrectPolicy_ForPremiumCustomer()
        {
            // Arrange
            var factory = new DiscountPolicyFactory();
            var calculator = new BillingCalculator(factory);

            // Act
            var finalAmount = calculator.CalculateBill("Premium", 20000);

            // Assert
            finalAmount.Should().Be(14000);
        }

        [Fact]
        public void BillingCalculator_InvalidCustomerType_ThrowsException()
        {
            // Arrange
            var factory = new DiscountPolicyFactory();
            var calculator = new BillingCalculator(factory);

            // Act
            var action = () => calculator.CalculateBill("Gold", 10000);

            // Assert
            action.Should().Throw<ArgumentException>()
                  .WithMessage("*Invalid customer type*");
        }
    }
}



