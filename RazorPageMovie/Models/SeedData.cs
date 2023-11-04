using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;

namespace RazorPageMovie.Models
{
    public class SeedData
    {
        public static void Iniciallize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMovieContext1(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPageMovieContext1>>()))
            {
                if (context == null || context.Movie == null) { 
                    throw new ArgumentNullException("Null RazorPageMovieContext");
                }

                if (context.Movie.Any()) {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Harry Potter",
                        RealeseDate = DateTime.Parse("1989-06-17"),
                        Genre = "Action",
                        Price = 300.20M,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "American Pie",
                        RealeseDate = DateTime.Parse("2001-12-19"),
                        Genre = "Comedy",
                        Price = 8.9M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Jackas",
                        RealeseDate = DateTime.Parse("2005-08-20"),
                        Genre = "Action",
                        Price = 9.21M,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "Jackas 2",
                        RealeseDate = DateTime.Parse("2006-08-01"),
                        Genre = "Action",
                        Price = 11.21M,
                        Rating = "NA"
                    }
                    ); 

                context.SaveChanges();
            }
        }
    }
}
