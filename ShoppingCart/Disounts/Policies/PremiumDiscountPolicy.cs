using ShoppingCart.Disounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Disounts.Policies
{
    public sealed class PremiumDiscountPolicy : DiscountPolicyBase
    {
        protected override IReadOnlyList<DiscountSlab> Slabs => new List<DiscountSlab>
        {
            new(0, 4000, 10),
            new(4000, 8000, 15),
            new(8000, 12000, 20),
            new(12000, null, 30)
        };
    }

}
