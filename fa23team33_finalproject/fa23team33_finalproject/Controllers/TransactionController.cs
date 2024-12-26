using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa23team33_finalproject.DAL;
using fa23team33_finalproject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace fa23team33_finalproject.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public TransactionController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Transaction
        public async Task<IActionResult> Index()
        {
              return _context.Transactions != null ? 
                          View(await _context.Transactions.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Transactions'  is null.");
        }

        // GET: Transaction/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions
                .Include(x=>x.TransactionDetails)
                .ThenInclude(x=>x.Schedules)
                .FirstOrDefaultAsync(m => m.TransactionID == id);

            if (transaction == null)
            {
                return NotFound();
            }

            var ticketType = transaction.TransactionDetails[0].Schedules.Price;

            var priceValue = Convert.ToInt32(Price.TicketTypePrices[ticketType]);

            transaction.TransactionSubtotal = priceValue;

            transaction.Status = (TransactionStatus)Status.NeedsReview;

                // Update the transaction subtotal based on your logic (e.g., sum of ticket prices)
                // transaction.TransactionSubtotal = CalculateSubtotal(transaction); 

                // Save changes to the database
                await _context.SaveChangesAsync();
            

            return View(transaction);
        }


        // GET: Transaction/Create
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create(int scheduleID)
        {
            if (User.IsInRole("Customer"))
            {
                Transaction transaction = new Transaction();
                ViewData["scheduleID"] = scheduleID;
                transaction.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                return View(transaction);
            }

            else
            {
                return View();
            }
        }

        // POST: Transaction/Create
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("User, TicketCount")] Transaction transaction, Schedule schedule)
        {
            // Find the next Order number from the utilities class
            transaction.TransactionNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

            // Set the date of this order
            transaction.TransactionDate = DateTime.Now;

            // Retrieve the entered TicketCount from the form
            int enteredTicketCount = transaction.TicketCount;

            // Associate the Order with the logged-in customer
            transaction.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            // If code gets this far, add the Order to the database
            _context.Add(transaction);
            await _context.SaveChangesAsync();

            // Send the user on to the action that will allow them to 
            // create an Order detail. Be sure to pass along the OrderID
            // that you created when you added the Order to the database above
            return RedirectToAction("Create", "TransactionDetail", new { ScheduleID = schedule.ScheduleId, TransactionID = transaction.TransactionID, TicketCount = enteredTicketCount });
        }


        // GET: Transaction/Checkout
        public async Task<IActionResult> Checkout(int transactionID, int scheduleID, TransactionDetail transactionDetail)
        {

            if (transactionID == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var t = await _context.Transactions
                .Include(x => x.TransactionDetails)
                .Include(x => x.User)
                .FirstOrDefaultAsync(m => m.TransactionID == transactionID);
            if (t == null)
            {
                return NotFound();
            }

            return View(t);


        }

        // POST: Transaction/Checkout
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout([Bind("TransactionDetailID,TransactionID")] TransactionDetail transactionDetail, string selectedSeat, int scheduleID, Transaction transaction, bool usePopcornPoints, bool isGift)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (usePopcornPoints || isGift)
                    {
                        // Perform actions if either checkbox is marked

                        if (usePopcornPoints)
                        {
                            // Handle when 'Use Popcorn Points' checkbox is marked
                        }

                        if (isGift)
                        {
                            // Handle when 'Is this a gift?' checkbox is marked
                        }

                        // Perform any other necessary actions for checkboxes being marked
                    }
                    else
                    {
                        // Redirect to Transaction/Details if neither checkbox is marked
                        return RedirectToAction("Details", "Transaction", new { id = transaction.TransactionID });
                    }

                    // Save changes to the database
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Details", "Transaction");
                }
                catch (Exception ex)
                {
                    // Handle exceptions and display error messages as needed
                    ModelState.AddModelError("", $"An error occurred while processing your request. Details: {ex}");
                }
            }

            // If ModelState is invalid or an exception occurs, return the view with errors
            return View(transaction);
        }




        // GET: Transaction/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // POST: Transaction/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionID,TransactionNumber,TransactionStatus,TransactionDate,TicketCount,PopcornPoints,TransactionSubtotal,Status")] Transaction transaction)
        {
            if (id != transaction.TransactionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.TransactionID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }


        private bool TransactionExists(int id)
        {
          return (_context.Transactions?.Any(e => e.TransactionID == id)).GetValueOrDefault();
        }

        public async Task<SelectList> GetAllCustomerUserNamesSelectList()
        {
            //create a list to hold the customers
            List<AppUser> allCustomers = new List<AppUser>();

            //See if the user is a customer
            foreach (AppUser dbUser in _context.Users)
            {
                //if the user is a customer, add them to the list of customers
                if (await _userManager.IsInRoleAsync(dbUser, "Customer") == true)//user is a customer
                {
                    allCustomers.Add(dbUser);
                }
            }

            //create a new select list with the customer emails
            SelectList sl = new SelectList(allCustomers.OrderBy(c => c.Email), nameof(AppUser.UserName), nameof(AppUser.Email));

            //return the select list
            return sl;

        }

        //private int GetPopcornPoints(Transaction transaction)
        //{
        //    int availablePoints = 6;

        //    try
        //    {
        //        // Assuming you have a reference to your DbContext named "_context"
        //        if (_context != null)
        //        {
        //            var userId = transaction.User.Id; // Assuming this retrieves the user's ID

        //            // Retrieve the total sum of PopcornPoints for the user's transactions
        //            availablePoints = _context.Transactions
        //                .Where(t => t.User.Id == transaction.User.Id) // Assuming there's a UserId property in the Transaction entity
        //                .Sum(t => t.PopcornPoints);
        //        }

        //            // Retrieve the User's transaction history to calculate available points
        //        //    var userTransactions = _context.Transactions
        //        //        .Where(t => t.User.Id == transaction.UserId) // Assuming there's a UserId property in the Transaction entity
        //        //        .ToList();

        //        //    // Calculate the total points earned
        //        //    availablePoints = userTransactions.Sum(t => t.PopcornPoints);
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception for further analysis (replace this with your logging mechanism)
        //        Console.WriteLine(ex.ToString());

        //        // Add error message to ModelState
        //        ModelState.AddModelError("", $"An error occurred while processing your request. Details: {ex}");
        //    }

        //    return availablePoints;
        //}


        //private int CalculatePointsEarned(int ticketCount)
        //{
        //    // Assuming each ticket purchase earns 50 popcorn points
        //    const int pointsPerTicketPurchase = 50;

        //    // Calculate total points earned based on the number of tickets purchased
        //    int totalPointsEarned = ticketCount * pointsPerTicketPurchase;

        //    return totalPointsEarned;
        //}


        //private int CalculatePointsNeeded(int ticketCount)
        //{
        //    // Assuming each ticket costs 100 popcorn points
        //    const int pointsPerTicket = 100;

        //    // Calculate total points needed based on the number of tickets purchased
        //    int totalPointsNeeded = ticketCount * pointsPerTicket;

        //    return totalPointsNeeded;
        //}


    }
}
