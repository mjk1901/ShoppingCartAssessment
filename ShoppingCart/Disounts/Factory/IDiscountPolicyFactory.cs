using ShoppingCart.Disounts.Policies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Disounts.Factory
{
    public interface IDiscountPolicyFactory
    {
        IDiscountPolicy GetPolicy(string customerType);
    }

}
