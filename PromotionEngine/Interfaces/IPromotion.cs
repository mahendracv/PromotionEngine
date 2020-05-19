using PromotionEngine.ShoppingCart;

namespace PromotionEngine.Interfaces
{
    /// <summary>
    /// Supports ApplyPromotion() on Cart items
    /// </summary>
    public interface IPromotion
    {
        Cart ApplyPromotion(Cart cart);
    }
}
