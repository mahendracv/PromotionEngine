using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.ShoppingCart
{
    /// <summary>
    /// Individual Order Item
    /// </summary>
    public class CartItem
    {
        public char SKUID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int QuantityWithPromotion { get; set; }
        public double PromotionalPricing { get; set; }
    }
}
