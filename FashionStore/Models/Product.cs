namespace FashionStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
