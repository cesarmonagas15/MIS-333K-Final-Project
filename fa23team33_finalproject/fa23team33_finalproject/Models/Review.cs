using fa23team33_finalproject;
using fa23team33_finalproject.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace fa23team33_finalproject.Models
{
    public enum Status { Approved, [Display(Name = "Needs Review")] NeedsReview }


    public class Review
    {

        public Int32 ReviewID { get; set; }
        public Int32 Rating { get; set; }
        public String? Description { get; set; }

        public Status Status {get; set;}



        //Nav props
        public AppUser User   { get; set; }
        public Movie Movies { get; set; }
    }
}

