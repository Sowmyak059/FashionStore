using FashionStore.Models;

namespace FashionStore.ViewModels
{
    public class ProductsViewModel
    {
        public IEnumerable<CategoryHeader> CategoryHeaders { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
