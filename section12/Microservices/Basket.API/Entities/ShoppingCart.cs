namespace Basket.API.Entities
{
    public class ShoppingCart(string userName)
    {
        public string? UserName { get; set; } = userName;
        public List<ShoppingCartItem>? Items { get; set; } = [];

        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;

                foreach (var item in Items)
                {
                    totalPrice += item.Price * item.Quantity;
                }
                return totalPrice;
            }
        }
    }
}
