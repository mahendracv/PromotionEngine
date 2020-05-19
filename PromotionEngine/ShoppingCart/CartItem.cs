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
    }
}
