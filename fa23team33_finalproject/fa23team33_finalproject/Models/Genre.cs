using System;
using System.Collections.Generic;

namespace fa23team33_finalproject.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }


        // Navigation property
        public List<Movie> Movies { get; set; }
        public Genre()
        {
            if (Movies == null)
            {
                Movies ??= new List<Movie>();
            }
        }
    }
}
