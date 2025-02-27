namespace FashionStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public string ReviewerName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; } // Rating out of 5
        public DateTime ReviewDate { get; set; }
        public Product Product { get; set; }
    }
}
