using PromotionEngine.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Interfaces
{
    public interface IPromotion
    {
        Cart ApplyPromotion(Cart cart);
    }
}
