namespace CCMovieDatabase.Models
{
    public class Movie
    {
        // this class is a model for a movie object in the database
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? MotionPictureRating { get; set; }
        // TODO: how do i relate data? genres
        public DateOnly ReleaseDate { get; set; }
    }
}
