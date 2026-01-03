using ShoppingCart.Disounts.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Billing
{
    public sealed class BillingCalculator
    {
        private readonly IDiscountPolicyFactory _policyFactory;

        public BillingCalculator(IDiscountPolicyFactory policyFactory)
        {
            _policyFactory = policyFactory;
        }

        public decimal CalculateBill(string customerType, decimal amount)
        {
            var policy = _policyFactory.GetPolicy(customerType);
            return policy.CalculateFinalAmount(amount);
        }
    }

}
