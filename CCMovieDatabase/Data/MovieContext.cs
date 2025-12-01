using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CCMovieDatabase.Models;
using System.Reflection;

namespace CCMovieDatabase.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<Rating> Ratings { get; set; } = default!;
        public DbSet<ActingCredit> ActingCredits { get; set; } = default!;
        public DbSet<CrewCredit> CrewCredits { get; set; } = default!;
        public DbSet<Article> Articles { get; set; } = default!;
        public DbSet<Character> Characters { get; set; } = default!;
        public DbSet<Person> Persons { get; set; } = default!;

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
                 new Movie { Id = 1, Title = "Shrek", ReleaseDate = new DateOnly(2001, 04, 26), Description = "A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.", RatingId = 1 },
                new Movie { Id = 2, Title = "Shrek 2", ReleaseDate = new DateOnly(2002, 04, 26), Description = "Shrek is back baby!", RatingId = 1 },
                new Movie { Id = 3, Title = "Men in Black", ReleaseDate = new DateOnly(1997,7,25), Description = "James, an NYC cop, is hired by Agent K of a secret government agency that monitors extraterrestrial life on Earth. Together, they must recover an item that has been stolen by an intergalactic villain.", RatingId = 1 },
                new Movie { Id = 4, Title = "Avatar: The Way of Water", ReleaseDate = new DateOnly(2022, 12, 16), Description = "Jake Sully lives with his newfound family formed on the extrasolar moon Pandora. Once a familiar threat returns to finish what was previously started, Jake must work with Neytiri and the army of the Na'vi race to protect their home.", RatingId = 1 },
                new Movie { Id = 5, Title = "Avengers: Infinity War", ReleaseDate = new DateOnly(2018, 4, 23), Description = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.", RatingId = 1},
                new Movie { Id = 6, Title = "Ratatouille", ReleaseDate = new DateOnly(2007,6,28), Description = "A rat who can cook makes an unusual alliance with a young kitchen worker at a famous Paris restaurant.", RatingId = 3},
                new Movie { Id = 7, Title = "Monsters, Inc.", ReleaseDate = new DateOnly(2001,10,28), Description = "In order to power the city, monsters have to scare children so that they scream. However, the children are toxic to the monsters, and after a child gets through, two monsters realize things may not be what they think", RatingId = 3}
            };

            modelBuilder.Entity<Movie>().HasData(movies);

            // article seed data
            var articles = new List<Article>
            { 
                new Article { ArticleId = 1, Title = "Welcome to CCMovieDatabase", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Slug = "hello_world", CreatedAt = new DateTime(2025, 11, 12), ModifiedAt = new DateTime(2025, 11, 12), Author = "Jesse", ThumbnailUrl = "https://craftypixels.com/placeholder-image/300", ShortDescription = "Lorem Ipsum and stuff", IsFeatured = true },
                new Article { ArticleId = 2, Title = "More Movies Added", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Slug = "hello_world2", CreatedAt = new DateTime(2025, 11, 12), ModifiedAt = new DateTime(2025, 11, 12), Author = "Jesse", ThumbnailUrl = "https://craftypixels.com/placeholder-image/300", ShortDescription = "Lorem Ipsum and stuff", IsFeatured = true },
                new Article { ArticleId = 3, Title = "For the love of movies", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Slug = "hello_world3", CreatedAt = new DateTime(2025, 11, 12), ModifiedAt = new DateTime(2025, 11, 12), Author = "Jesse", ThumbnailUrl = "https://craftypixels.com/placeholder-image/300", ShortDescription = "Lorem Ipsum and stuff", IsFeatured = true },
                new Article { ArticleId = 4, Title = "I wrote this", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Slug = "hello_world4", CreatedAt = new DateTime(2025, 11, 12), ModifiedAt = new DateTime(2025, 11, 12), Author = "Jesse", ThumbnailUrl = "https://craftypixels.com/placeholder-image/300", ShortDescription = "Lorem Ipsum and stuff", IsFeatured = true },
            };

            modelBuilder.Entity<Article>().HasData(articles);

        }
    }
}
