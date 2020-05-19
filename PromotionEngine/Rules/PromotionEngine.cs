using PromotionEngine.Interfaces;
using PromotionEngine.ShoppingCart;
using System.Collections.Generic;

namespace PromotionEngine.Rules
{
    /// <summary>
    /// PromotionEngine apply Promotions on the cart
    /// </summary>
    public class PromotionEngine
    {
        List<IPromotion> rules;

        public PromotionEngine()
        {
            rules = new List<IPromotion>();
            rules.Add(new PromotionA());
            rules.Add(new PromotionB());
            rules.Add(new PromotionCD());
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
