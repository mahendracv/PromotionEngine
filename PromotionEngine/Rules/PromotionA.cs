using PromotionEngine.Interfaces;
using PromotionEngine.ShoppingCart;
using System.ComponentModel;
using System.Linq;

namespace PromotionEngine.Rules
{
    [Description("Buy 3 items of A's for 130")]
    public class PromotionA : IPromotion
    {
        char PromotionSKUID = 'A';
        int PromotionQuantity = 3;
        double PromotionPrice = 130;

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
