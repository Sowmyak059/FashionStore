namespace FashionStore.Models
{
    public class WishlistItem
    {
        public int WishlistItemID { get; set; }
        public string UserId { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
