namespace FashionStore.Models
{
    //Men - Women - Kids - Home & Living - Beauty
    public class MainCategory
    {
        public int MainCategoryID { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryHeader> CategoryHeaders { get; set; }
    }
}
