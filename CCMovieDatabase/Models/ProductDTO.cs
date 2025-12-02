namespace CCMovieDatabase.Models
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string Tag { get; set; }

        // navigation property
        //public Category Category { get; set; }
        public string CategoryName { get; set; }
    }
}
