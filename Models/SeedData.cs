using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Star Wars: Episode I - The Phantom Menace",
                    ReleaseDate = DateTime.Parse("1999-05-19"),
                    Genre = "Science Fiction",
                    Price = 10.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Star Wars: Episode II - Attack of the Clones",
                    ReleaseDate = DateTime.Parse("2002-05-16"),
                    Genre = "Science Fiction",
                    Price = 11.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Star Wars: Episode III - Revenge of the Sith",
                    ReleaseDate = DateTime.Parse("2005-05-19"),
                    Genre = "Science Fiction",
                    Price = 12.99M,
                    Rating = "PG-13"
                }
            );
            context.SaveChanges();
        }
    }
}