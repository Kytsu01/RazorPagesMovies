using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovies.Movies
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Gender { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
