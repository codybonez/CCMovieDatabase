namespace CCMovieDatabase.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        // navigation property
        public Category Category { get; set; }
    }
}
