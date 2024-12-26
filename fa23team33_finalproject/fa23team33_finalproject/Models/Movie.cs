using System;

namespace fa23team33_finalproject.Models
{
    public class Movie
    {
        public Int32 MovieID { get; set; }

        public String Title { get; set; }
        public String Description { get; set; }
        public String Tagline { get; set; }
        public Int32 ReleaseYear { get; set; }
        public String MPAArating { get; set; }
        // Actors
        public String Actors { get; set; }
        public Int32 RunTime { get; set; }

        //Nav props
        public Genre Genre { get; set; }
        public List<Review> Reviews { get; set; }

        public List<Schedule> Schedules { get; set; }

        public Movie()
        {
            if (Reviews == null)
            {
                Reviews ??= new List<Review>();
            }
        }
    }
}


