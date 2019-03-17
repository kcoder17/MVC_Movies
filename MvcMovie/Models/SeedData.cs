using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Sons of Provo",
                        ReleaseDate = DateTime.Parse("2004-10-30"),
                        Genre = "Comedy",
                        Price = 5.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-22"),
                        Genre = "Comedy",
                        Price = 5.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 5.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The Home Teachers",
                        ReleaseDate = DateTime.Parse("2004-1-9"),
                        Genre = "Comedy",
                        Price = 5.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-1-30"),
                        Genre = "Romantic Comedy",
                        Price = 5.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The Singles 2nd Ward",
                        ReleaseDate = DateTime.Parse("2007-12-11"),
                        Genre = "Romantic Comedy",
                        Price = 5.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "Mobsters and Mormons",
                        ReleaseDate = DateTime.Parse("2005-9-9"),
                        Genre = "Comedy",
                        Price = 5.99M,
                        Rating = "PG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}