namespace CCMovieDatabase.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string Author { get; set; }

        public string? ThumbnailUrl { get; set; }
        public string ShortDescription { get; set; }
        public bool IsFeatured { get; set; }
    }
}
