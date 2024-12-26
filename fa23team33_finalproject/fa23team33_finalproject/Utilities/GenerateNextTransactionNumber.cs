using fa23team33_finalproject.DAL;
using System;
using System.Linq;


namespace fa23team33_finalproject.Utilities
{
    public static class GenerateNextOrderNumber
    {
        public static Int32 GetNextOrderNumber(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int32 START_NUMBER = 100001;

            Int32 intMaxOrderNumber; //the current maximum course number
            Int32 intNextOrderNumber; //the course number for the next class

            if (_context.Transactions.Count() == 0) //there are no registrations in the database yet
            {
                intMaxOrderNumber = START_NUMBER; //registration numbers start at 101
            }
            else
            {
                intMaxOrderNumber = _context.Transactions.Max(c => c.TransactionNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxOrderNumber < START_NUMBER)
            {
                intMaxOrderNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextOrderNumber = intMaxOrderNumber + 1;

            //return the value
            return intNextOrderNumber;
        }

    }
}