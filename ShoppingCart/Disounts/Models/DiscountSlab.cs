using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Disounts.Models
{
    public sealed class DiscountSlab
    {
        public decimal MinAmount { get; }
        public decimal? MaxAmount { get; }
        public decimal DiscountPercentage { get; }

        public DiscountSlab(decimal min, decimal? max, decimal discount)
        {
            MinAmount = min;
            MaxAmount = max;
            DiscountPercentage = discount;
        }

        public bool IsMatch(decimal amount) =>
            amount >= MinAmount && (MaxAmount == null || amount <= MaxAmount);
    }

}
