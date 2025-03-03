namespace FashionStore.Models
{
    public class CartItem
    {
        public int CartItemID { get; set; }
        public string UserId { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; } = 1; // Default quantity is 1
    }
}