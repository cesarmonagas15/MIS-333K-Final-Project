
using fa23team33_finalproject.DAL;
using fa23team33_finalproject.Models;
using fa23team33_finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace fa23team33_finalproject.Seeding
{
    public static class SeedPrices
    {
        //You will call this method from the SeedController to add categories
        public static void SeedAllPrices(AppDbContext db)
        {
            //create a list of categories to add
            List<Price> AllPrices = new List<Price>();


            AllPrices.Add(new Price()
            {
                TicketType = TicketType.SpecialEvent,

            });
            AllPrices.Add(new Price()
            {
                TicketType = TicketType.Matinee,

            });
            AllPrices.Add(new Price()
            {
                TicketType = TicketType.DiscountTuesday,

            });
            AllPrices.Add(new Price()
            {
                TicketType = TicketType.WeekdayBase

            });
            AllPrices.Add(new Price()
            {
                TicketType = TicketType.Weekends,

            });
            //create some counters to help debug problems
            Int32 intPriceID = 0;
            String strPriceTitle = "Start";

            //loop through the list to add or update the job posting
            try
            {
                foreach (Price seedPrice in AllPrices)
                {
                    //update the counters
                    intPriceID = seedPrice.PriceId;
                    TicketType enumTicketType = seedPrice.TicketType;
                    //see if the job posting is already in the database using the UniqueIdentifier
                    Price dbPrice = db.Prices.FirstOrDefault(m => m.PriceId == seedPrice.PriceId);

                    //if job posting is null, job posting is not in database
                    if (dbPrice == null)
                    {
                        //Add the job posting to the database
                        db.Prices.Add(seedPrice);
                        db.SaveChanges();
                    }
                    else //the job posting is in the database - reset all fields except ID and Unique Identifier
                    {
                        dbPrice.TicketType = seedPrice.TicketType;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) //throw error if there is a problem in the database
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the job posting with the title: ");
                msg.Append(" (PriceID: ");
                msg.Append(intPriceID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}