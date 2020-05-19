using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.ShoppingCart
{
    public class Cart
    {
        /// <summary>
        /// List of SKUs
        /// </summary>
        public List<SKU> SKUList { get; }

        /// <summary>
        /// Assume cart items will contain max one entry for any SKU
        /// </summary>
        public List<CartItem> OrderItems { get; set; }

        public Cart()
        {
            SKUList = SKU.GetList();
            OrderItems = new List<CartItem>();
        }

        /// <summary>
        /// Calculate total order value
        /// </summary>
        /// <returns></returns>
        public double CalculateTotal()
        {
            return 100;
        }
    }
}
