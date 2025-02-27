namespace FashionStore.Models
{
    //T-Shirts, Jeans, Shoes
    public class Category
    {
        public int CategoryID { get; set; }
        public int CategoryHeaderID { get; set; }
        public string Name { get; set; }
        public CategoryHeader CategoryHeader { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
