using System;
using System.Collections.Generic;

namespace MovieWeb.Models
{
    public partial class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Genere { get; set; }
        public string? Director { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
