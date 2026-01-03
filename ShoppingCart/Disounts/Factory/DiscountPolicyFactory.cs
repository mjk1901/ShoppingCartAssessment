using ShoppingCart.Disounts.Policies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Disounts.Factory
{
    public sealed class DiscountPolicyFactory : IDiscountPolicyFactory
    {
        private readonly Dictionary<string, IDiscountPolicy> _policies;

        public DiscountPolicyFactory()
        {
            _policies = new Dictionary<string, IDiscountPolicy>(StringComparer.OrdinalIgnoreCase)
            {
                ["Regular"] = new RegularDiscountPolicy(),
                ["Premium"] = new PremiumDiscountPolicy()
            };
        }

        public IDiscountPolicy GetPolicy(string customerType)
        {
            if (!_policies.TryGetValue(customerType, out var policy))
                throw new ArgumentException("Invalid customer type");

            return policy;
        }
    }

}
