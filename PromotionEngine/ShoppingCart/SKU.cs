using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.ShoppingCart
{
    public class SKU
    {
        public char SKUID { get; set; }
        public double Price { get; set; }
        /// <summary>
        /// Hardcoded SKU list for demo. Can be pulled from external sources
        /// </summary>
        /// <returns></returns>
        public static List<SKU> GetList()
        {
            return new List<SKU>()
            {
                new SKU() { SKUID = 'A', Price = 50 },
                new SKU() { SKUID = 'B', Price = 30 },
                new SKU() { SKUID = 'C', Price = 20 },
                new SKU() { SKUID = 'D', Price = 15 }
            };
        }
    }
}
