namespace CCMovieDatabase.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<CrewCredit> CrewCredits { get; set; }
        public virtual ICollection<ActingCredit> ActingCredits { get; set; }
    }
}
