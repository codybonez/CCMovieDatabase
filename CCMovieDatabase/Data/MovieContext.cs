using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CCMovieDatabase.Models;

namespace CCMovieDatabase.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<CCMovieDatabase.Models.Movie> Movie { get; set; } = default!;
        public DbSet<CCMovieDatabase.Models.Rating> Ratings { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var ratings = new List<Rating>
            {
                new Rating { RatingId = 1, Name = "PG-13" },
                new Rating { RatingId = 2, Name = "R" },
                new Rating { RatingId = 3, Name = "G" }
            };
            modelBuilder.Entity<Rating>().HasData(ratings);

            // right here we seed data
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "Men in Black", ReleaseDate = new DateOnly(1997,7,25), Description = "James, an NYC cop, is hired by Agent K of a secret government agency that monitors extraterrestrial life on Earth. Together, they must recover an item that has been stolen by an intergalactic villain.", RatingId = 1 },
                new Movie { Id = 2, Title = "Avatar: The Way of Water", ReleaseDate = new DateOnly(2022, 12, 16), Description = "Jake Sully lives with his newfound family formed on the extrasolar moon Pandora. Once a familiar threat returns to finish what was previously started, Jake must work with Neytiri and the army of the Na'vi race to protect their home.", RatingId = 1 },
                new Movie { Id = 3, Title = "Avengers: Infinity War", ReleaseDate = new DateOnly(2018, 4, 23), Description = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.", RatingId = 1},
                new Movie { Id = 4, Title = "Ratatouille", ReleaseDate = new DateOnly(2007,6,28), Description = "A rat who can cook makes an unusual alliance with a young kitchen worker at a famous Paris restaurant.", RatingId = 3},
                new Movie { Id = 5, Title = "Monsters, Inc.", ReleaseDate = new DateOnly(2001,10,28), Description = "In order to power the city, monsters have to scare children so that they scream. However, the children are toxic to the monsters, and after a child gets through, two monsters realize things may not be what they think", RatingId = 3}
            };

            modelBuilder.Entity<Movie>().HasData(movies);

        }
    }
}
