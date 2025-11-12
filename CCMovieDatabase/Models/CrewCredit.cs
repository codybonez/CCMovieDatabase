namespace CCMovieDatabase.Models
{
    public class CrewCredit
    {
        public int CrewCreditId { get; set; }
        public int PersonId { get; set; }
        public int MovieId { get; set; }
        public string Description { get; set; }

        // relational syntactic sugar
        public Movie Movie { get; set; }
        public Person Person { get; set; }
    }
}
