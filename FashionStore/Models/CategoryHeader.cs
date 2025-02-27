namespace FashionStore.Models
{
    //Topware, Footware, Gadgets,Lights
    public class CategoryHeader
    {
        public int CategoryHeaderID { get; set; }
        public int MainCategoryID { get; set; }
        public string Name { get; set; }
        public MainCategory MainCategory { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
