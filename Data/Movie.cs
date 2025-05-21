using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BlazorMoviesProject.Data
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public int Year { get; set; }

        public float Rating { get; set; }

        public string? CoverImagePath { get; set; }

        public List<Review> Reviews { get; set; } = new();
    }
}
