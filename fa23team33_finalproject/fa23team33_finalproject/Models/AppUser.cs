using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

//TODO: Make this namespace match your project name
namespace fa23team33_finalproject.Models
{
    public class AppUser : IdentityUser
    {
        //TODO: Add custom user fields - first name is included as an example


        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }


        [Display(Name = "Full Name")]
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [Display(Name = "Birthday")]
        public DateTime? Birthday { get; set; }

        [Display(Name = "Street Address")]
        public String StreetAddress { get; set; }

        [Display(Name = "City")]
        public String City { get; set; }

        [Display(Name = "State")]
        public String State { get; set; }

        [Display(Name = "Zip code")]
        public String ZipCode { get; set; }

        [Display(Name = "Full Address")]
        public String FullAddress
        {
            get { return StreetAddress + " " + City + ", " + State + " " + ZipCode; }
        }

        //nav props
        public List<Transaction> Transactions { get; set; }
        public List<Review> Reviews { get; set; }

        public AppUser()
        {
            if (Transactions == null)
            {
                Transactions ??= new List<Transaction>();
            }
            if (Reviews == null)
            {
                Reviews ??= new List<Review>();
            }
        }


        public static implicit operator string?(AppUser? v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator AppUser(string v)
        {
            throw new NotImplementedException();
        }
    }
}
