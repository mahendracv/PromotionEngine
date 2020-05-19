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

        public Cart()
        {
            SKUList = SKU.GetList();
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
