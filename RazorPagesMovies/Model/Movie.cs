using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovies.Movies
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Enter the movie genre")]
        [StringLength(30, MinimumLength = 3)]
        public string Gender { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Range(0, 10)]
        public int Rate { get; set; } = 0;
    }
}
