using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieWeb.Models
{
    public partial class Category
    {
        public Category()
        {
            Movies = new HashSet<Movie>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        [DisplayName("Display Order")]
        public int DisplayOder { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
