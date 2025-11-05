namespace CCMovieDatabase.Models
{
    public class ActingCredit
    {
        public int ActingCreditId { get; set; }
        public int PersonId { get; set; }
        public int CharacterId { get; set; }

        // navigation properties
        public Person Person { get; set; }
        public Character Character { get; set; }
    }
}
