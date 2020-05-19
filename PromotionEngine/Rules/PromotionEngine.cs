using PromotionEngine.Interfaces;
using PromotionEngine.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Rules
{
    public class PromotionEngine
    {
        List<IPromotion> rules;

        public PromotionEngine()
        {
            rules = new List<IPromotion>();
            rules.Add(new PromotionA());
            rules.Add(new PromotionB());
        }

        public Cart ApplyPromotion(Cart cart)
        {
            foreach (var rule in this.rules)
            {
                cart = rule.ApplyPromotion(cart);
            }

            return cart;
        }
    }
}
