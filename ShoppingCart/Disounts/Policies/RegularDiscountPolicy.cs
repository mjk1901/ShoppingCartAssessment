using ShoppingCart.Disounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Disounts.Policies
{
    public sealed class RegularDiscountPolicy : DiscountPolicyBase
    {
        protected override IReadOnlyList<DiscountSlab> Slabs => new List<DiscountSlab>
        {
            new(0, 5000, 0),
            new(5000, 10000, 10),
            new(10000, null, 20)
        };
    }

}
