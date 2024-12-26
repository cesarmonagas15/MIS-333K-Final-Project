using System.ComponentModel.DataAnnotations;


namespace fa23team33_finalproject.Models
{
    public enum TransactionStatus { Pending, Purchased, Cancelled }
    public class Transaction
    {
        private const Decimal TAX_RATE = 0.0825m;

        public Int32 TransactionID { get; set; }

        [Display(Name = "Transaction Number")]
        public Int32 TransactionNumber { get; set; }

        [Display(Name = "Transaction Status")]
        public TransactionStatus TransactionStatus { get; set; }

        [Display(Name = "Transaction Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime TransactionDate { get; set; }

        [Display(Name = "Ticket Count")]
        public Int32 TicketCount { get; set; }

        [Display(Name = "Popcorn Points")]
        public Int32 PopcornPoints { get; set; }


        [Display(Name = "Transaction Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Int32 TransactionSubtotal { get; set; }

        [Display(Name = "Transaction Tax")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TransactionTax
        {
            get { return TransactionSubtotal * TAX_RATE; }
        }

        [Display(Name = "Transaction Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TransactionTotal
        {
            get { return TransactionSubtotal + TransactionTax; }
        }

        [Display(Name = "Registration Status:")]
        public TransactionStatus Status { get; set; }

        // NAVIGATIONAL PROPERTIES
        public AppUser User { get; set; }

        public List<TransactionDetail> TransactionDetails { get; set; }
        public Transaction()
        {
            if (TransactionDetails == null)
            {
                TransactionDetails ??= new List<TransactionDetail>();
            }
        }

    }
}
