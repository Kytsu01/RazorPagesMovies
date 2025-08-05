using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Data;
using RazorPagesMovies.Movies;

namespace RazorPagesMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovies.Data.RazorPagesMoviesContext _context;

        public IndexModel(RazorPagesMovies.Data.RazorPagesMoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MovieGender { get; set; }

        public SelectList Genders { get; set; }

        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movie select m;

            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                movies = movies.Where(m => m.Title.Contains(SearchTerm));
            }

            if (!string.IsNullOrWhiteSpace(MovieGender))
            {
                movies = movies.Where(f => f.Gender == MovieGender);
            }

            Genders = new SelectList(await _context.Movie.Select(o => o.Gender).Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
