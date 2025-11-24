namespace CCMovieDatabase.Models
{
    public class MovieViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public int ToastCount { get; set; }
    }
}
