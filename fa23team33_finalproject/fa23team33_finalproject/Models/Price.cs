using System.ComponentModel.DataAnnotations;

namespace fa23team33_finalproject.Models
{
    public enum TicketType
    {
        [Display(Name = "Matinee")] Matinee,
        [Display(Name = "Weekday (Base)")] WeekdayBase,
        [Display(Name = "Weekends")] Weekends,
        [Display(Name = "Special Event")] SpecialEvent,
        [Display(Name = "Discount Tuesday")] DiscountTuesday
    }

    public class Price
    {
        public Int32 PriceId { get; set; }

        //Ticket Type
        [Display(Name = "Ticket Type:")]
        public TicketType TicketType { get; set; }

        // Dictionary to store prices for each ticket type
        public static readonly Dictionary<TicketType, decimal> TicketTypePrices = new Dictionary<TicketType, decimal>
        {
            { TicketType.Matinee, 5.0m },
            { TicketType.WeekdayBase, 10.0m },
            { TicketType.Weekends, 12.0m },
            { TicketType.SpecialEvent, 15.0m },
            { TicketType.DiscountTuesday, 8.0m }
        };


        //Price Value
        // Automatically fetch the price based on TicketType
        [Display(Name = "Price:")]
        public decimal PriceValue => TicketTypePrices[TicketType];



        //Navigational Properties
        public List<Schedule> Schedules { get; set; }
        public Price()
        {
            if (Schedules == null)
            {
                Schedules ??= new List<Schedule>();
            }
        }

    }


}
