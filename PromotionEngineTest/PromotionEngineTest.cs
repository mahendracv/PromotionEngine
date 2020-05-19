using PromotionEngine.ShoppingCart;
using System;
using System.Collections.Generic;
using Xunit;

namespace PromotionEngineTest
{
    public class PromotionEngineTest
    {
        private Cart shoppingCart;

        public PromotionEngineTest()
        {
            shoppingCart = new Cart();
        }

        [Fact]
        public void TestCase_Scenario_A()
        {
            var result = shoppingCart.CalculateTotal();
            Assert.Equal(100, result);
        }
    }
}
