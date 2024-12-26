using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace fa23team33_finalproject.Models
{
    public enum SearchType { GreaterThan, LessThan }
    public class SearchViewModel
    {
        [Display(Name = "Search by Title:")]
        public String SearchTitle { get; set; }

        [Display(Name = "Search by Tagline:")]
        public String SearchTagline { get; set; }

        [Display(Name = "Search by Genre:")]
        public Int32 SelectedGenreId { get; set; }

        [Display(Name = "Search by Release Year")]
        public Int32 SearchReleaseYear { get; set; }

        [Display(Name = "Search by MPAARating:")]
        public String SelectedMPAARating { get; set; }

        [Display(Name = "Search by Customer Ratings:")]
        public Int32 SearchRating { get; set; }

        [Display(Name = "Search Type:")]
        public SearchType SearchType { get; set; }

        [Display(Name = "Search by Actors:")]
        public String SearchActors { get; set; }
    }
}