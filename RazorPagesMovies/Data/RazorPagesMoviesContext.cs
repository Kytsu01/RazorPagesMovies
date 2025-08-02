using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Movies;

namespace RazorPagesMovies.Data
{
    public class RazorPagesMoviesContext : DbContext
    {
        public RazorPagesMoviesContext (DbContextOptions<RazorPagesMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovies.Movies.Movie> Movie { get; set; } = default!;
    }
}
