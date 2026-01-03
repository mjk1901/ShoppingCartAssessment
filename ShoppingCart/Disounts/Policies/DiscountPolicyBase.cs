using ShoppingCart.Disounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Disounts.Policies
{
    public abstract class DiscountPolicyBase : IDiscountPolicy
    {
        protected abstract IReadOnlyList<DiscountSlab> Slabs { get; }

        public decimal CalculateFinalAmount(decimal purchaseAmount)
        {
            var slab = Slabs.First(s => s.IsMatch(purchaseAmount));
            var discount = purchaseAmount * slab.DiscountPercentage / 100;
            return purchaseAmount - discount;
        }
    }

}
