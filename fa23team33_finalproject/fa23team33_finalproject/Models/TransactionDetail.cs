using System.ComponentModel.DataAnnotations;
using fa23team33_finalproject.Models;

namespace fa23team33_finalproject.Models
{
    public class TransactionDetail
    {
        public Int32 TransactionDetailID { get; set; }


        [Display(Name = "Movie")]
        public String Movie { get; set; }

        [Display(Name = "Seat")]
        public String Seat { get; set; }

        [Display(Name = "Senior Discount")]
        public Boolean? SeniorDiscount { get; set; }

        [Display(Name = "Tuesday Discount")]
        public Boolean? TuesdayDiscount { get; set; }

        [Display(Name = "DateTime")]
        public DateTime DateTime { get; set; }

        [Display(Name = "Theater")]
        public Theater Theater { get; set; }

        [Display(Name = "TicketPrice")]
        public Int32 TicketPrice { get; set; }

        [Display(Name = "Popcorn Points")]
        public Int32 PopcornPoints { get; set; }


        // NAVIGATIONAL PROPERTIES
        public Transaction Transaction { get; set; }
        public Schedule Schedules { get; set; }
    


    }
}
