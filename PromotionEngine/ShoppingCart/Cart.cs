using System;
using System.Collections.Generic;
using System.Linq;
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

        Rules.PromotionEngine ruleEngine;
        public Cart()
        {
            SKUList = SKU.GetList();
            OrderItems = new List<CartItem>();
            ruleEngine = new Rules.PromotionEngine();
        }

        /// <summary>
        /// Calculate total order value
        /// </summary>
        /// <returns></returns>
        public double CalculateTotal()
        {
            var cart = ruleEngine.ApplyPromotion(this);

            double result = 0.0;
            foreach (var product in cart.OrderItems)
            {
                SKU sku = this.SKUList.FindAll(x => x.SKUID.Equals(product.SKUID)).FirstOrDefault();
                product.Price = sku.Price;

                result += product.PromotionalPricing + (product.Quantity * sku.Price);
            }

            return result;
        }
    }
}
