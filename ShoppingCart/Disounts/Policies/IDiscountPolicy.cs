using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Disounts.Policies
{
    public interface IDiscountPolicy
    {
        decimal CalculateFinalAmount(decimal purchaseAmount);
    }

}
