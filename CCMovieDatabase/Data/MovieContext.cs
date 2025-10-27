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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // right here we seed data
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "Shrek", ReleaseDate = new DateOnly(2001, 04, 26), Description = "A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.", MotionPictureRating = "PG" },
                new Movie { Id = 2, Title = "Shrek 2", ReleaseDate = new DateOnly(2002, 04, 26), Description = "Shrek is back baby!", MotionPictureRating = "PG" },
            };

            modelBuilder.Entity<Movie>().HasData(movies);

        }
    }
}
