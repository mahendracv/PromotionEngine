using PromotionEngine.Interfaces;
using PromotionEngine.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Rules
{
    public class PromotionA : IPromotion
    {
        public Cart ApplyPromotion(Cart cart)
        {
            return cart;
        }
    }
}
