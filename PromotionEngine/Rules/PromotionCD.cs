using PromotionEngine.Interfaces;
using PromotionEngine.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Rules
{
    public class PromotionCD : IPromotion
    {
        string PromotionDescription = "Buy C & D for 30";

        char PromotionSKUIDC = 'C';
        int PromotionQuantityC = 1;

        char PromotionSKUIDD = 'D';
        int PromotionQuantityD = 1;

        double PromotionPrice = 30;

        public Cart ApplyPromotion(Cart cart)
        {
            CartItem productc = cart.OrderItems.FindAll(x => x.SKUID.Equals(this.PromotionSKUIDC)).FirstOrDefault();
            CartItem productd = cart.OrderItems.FindAll(x => x.SKUID.Equals(this.PromotionSKUIDD)).FirstOrDefault();

            if (productc != null && productd != null)
            {
                int iligiableForPromotionc = (productc.Quantity / this.PromotionQuantityC);
                int iligiableForPromotiond = (productd.Quantity / this.PromotionQuantityD);

                int iligiableForPromotion = Math.Min(iligiableForPromotionc, iligiableForPromotiond);

                if (iligiableForPromotion > 0)
                {
                    productc.Quantity -= (iligiableForPromotion * this.PromotionQuantityC);
                    productc.QuantityWithPromotion += (iligiableForPromotion * this.PromotionQuantityC);

                    productd.Quantity -= (iligiableForPromotion * this.PromotionQuantityD);
                    productd.QuantityWithPromotion += (iligiableForPromotion * this.PromotionQuantityD);

                    productc.PromotionalPricing += (this.PromotionPrice * iligiableForPromotion);
                }
            }

            return cart;
        }
    }
}
