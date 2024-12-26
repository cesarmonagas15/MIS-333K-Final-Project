using System.ComponentModel.DataAnnotations;

namespace fa23team33_finalproject.Models
{
    public enum Theater
    {
        [Display(Name = "Theater 1")] Theater1,
        [Display(Name = "Theater 2")] Theater2
    }


    public class Schedule
    {
        public Int32 ScheduleId { get; set; }

        //Date time
        [Display(Name = "Start Time:")]
        [Required(ErrorMessage = "Start time is required.")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime DateTime { get; set; }

        //Theater
        [Display(Name = "Theater:")]
        public Theater Theater { get; set; }

        //Price
        [Display(Name = "Price:")]
        public TicketType Price { get; set; }

        //Special Event
        public Boolean SpecialEvent { get; set; }

        //Navigational Properties
       
        public List<TransactionDetail> TransactionDetails { get; set; }
        public Movie Movies { get; set; }
        public Schedule()
        {

            if (TransactionDetails == null)
            {
                TransactionDetails ??= new List<TransactionDetail>();
            }

        }
    }
}
