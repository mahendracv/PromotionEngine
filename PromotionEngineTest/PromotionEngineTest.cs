using PromotionEngine.ShoppingCart;
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
            List<CartItem> OrderItems = new List<CartItem>()
            {
                new CartItem() { SKUID = 'A', Quantity = 1 },
                new CartItem() { SKUID = 'B', Quantity = 1 },
                new CartItem() { SKUID = 'C', Quantity = 1 }
            };

            shoppingCart.OrderItems = OrderItems;

            var result = shoppingCart.CalculateTotal();
            Assert.Equal(100, result);
        }

        [Fact]
        public void TestCase_Scenario_B()
        {
            List<CartItem> OrderItems = new List<CartItem>()
            {
                new CartItem() { SKUID = 'A', Quantity = 5 },
                new CartItem() { SKUID = 'B', Quantity = 5 },
                new CartItem() { SKUID = 'C', Quantity = 1 }
            };

            shoppingCart.OrderItems = OrderItems;

            var result = shoppingCart.CalculateTotal();

            Assert.Equal(370, result);
        }

        [Fact]
        public void TestCase_Scenario_C()
        {
            List<CartItem> OrderItems = new List<CartItem>()
            {
                new CartItem() { SKUID = 'A', Quantity = 3 },
                new CartItem() { SKUID = 'B', Quantity = 5 },
                new CartItem() { SKUID = 'C', Quantity = 1 },
                new CartItem() { SKUID = 'D', Quantity = 1 }
            };

            shoppingCart.OrderItems = OrderItems;

            var result = shoppingCart.CalculateTotal();

            Assert.Equal(280, result);
        }
    }
}
