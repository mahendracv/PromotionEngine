using PromotionEngine.Interfaces;
using PromotionEngine.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Rules
{
    public class PromotionB : IPromotion
    {
        private string PromotionDescription = "Buy 2 items of B's for 45";

        char PromotionSKUID = 'B';
        int PromotionQuantity = 2;
        double PromotionPrice = 45;

        public Cart ApplyPromotion(Cart cart)
        {
            CartItem product = cart.OrderItems.FindAll(x => x.SKUID.Equals(this.PromotionSKUID)).FirstOrDefault();
            if (product != null)
            {
                int iligiableForPromotion = (product.Quantity / this.PromotionQuantity);

                if (iligiableForPromotion > 0)
                {
                    product.Quantity -= (iligiableForPromotion * this.PromotionQuantity);
                    product.QuantityWithPromotion += (iligiableForPromotion * this.PromotionQuantity);
                    product.PromotionalPricing += (this.PromotionPrice * iligiableForPromotion);
                }
            }
            return cart;
        }
    }
}
