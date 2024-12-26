using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa23team33_finalproject.DAL;
using fa23team33_finalproject.Models;

namespace fa23team33_finalproject.Controllers
{
    public class TransactionDetailController : Controller
    {
        private readonly AppDbContext _context;

        public TransactionDetailController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TransactionDetail
        public async Task<IActionResult> Index()
        {
              return _context.TransactionDetails != null ? 
                          View(await _context.TransactionDetails.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.TransactionDetails'  is null.");
        }

        // GET: TransactionDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TransactionDetails == null)
            {
                return NotFound();
            }

            var transactionDetail = await _context.TransactionDetails
                .FirstOrDefaultAsync(m => m.TransactionDetailID == id);
            if (transactionDetail == null)
            {
                return NotFound();
            }

            return View(transactionDetail);
        }

        // GET: TransactionDetail/Create
        public IActionResult Create(int transactionID, int scheduleID)

        {
            //create a new instance of the OrderDetail class
            TransactionDetail td = new TransactionDetail();

            //find the order that should be associated with this order
            Transaction dbTransaction = _context.Transactions.Find(transactionID);

            ViewData["scheduleID"] = scheduleID;


            Schedule dbSchedule = _context.Schedules.Find(scheduleID);

            //set the new order detail's order equal to the order you just found
            td.Transaction = dbTransaction;

            td.Schedules = dbSchedule;

            //populate the ViewBag with a list of existing products
            ViewBag.AllSeats = GetSeatSelectList(td);

            //pass the newly created order detail to the view
            return View(td);

        }

        // POST: TransactionDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionDetailID,TransactionID")] TransactionDetail transactionDetail, String selectedSeat, int scheduleID, Transaction transaction)
        {

            // Check if TempData contains QuantityCount, and initialize to 1 if not present
            var QuantityCount = TempData.ContainsKey("QuantityCount") ? (int)TempData["QuantityCount"] : 0;

            // If user has not entered all fields, send them back to try again
            if (!ModelState.IsValid)
            {
                ViewBag.AllSeats = GetSeatSelectList(transactionDetail);
                return View(transactionDetail);
            }

            try
            {

                ViewData["scheduleID"] = scheduleID;

                // Fetch the schedule details from the database based on the provided schedule ID
                Schedule dbSchedule = _context.Schedules
                                            .Include(s => s.Movies) // Include the Movies navigation property
                                            .FirstOrDefault(s => s.ScheduleId == scheduleID);

                if (dbSchedule == null)
                {
                    ModelState.AddModelError("Schedules.ScheduleId", "Invalid schedule ID.");
                    ViewBag.AllSeats = GetSeatSelectList(transactionDetail);
                    return View(transactionDetail);
                }
                else
                {
                    transactionDetail.Schedules = dbSchedule;
                }



                // Fetch the movie details from the database based on the selected movie ID
                Movie dbMovie = _context.Movies.Find(transactionDetail.Schedules.Movies.MovieID);

                Transaction dbTransaction = _context.Transactions
                                            .Include(s => s.User) // Include the User navigation property
                                            .FirstOrDefault(s => s.TransactionID == transaction.TransactionID);


                if (dbMovie == null)
                {
                    ModelState.AddModelError("Movie", "Invalid movie title.");
                    ViewBag.AllSeats = GetSeatSelectList(transactionDetail);
                    return View(transactionDetail);
                }



                // Set the properties of the transactionDetail instance
                transactionDetail.Movie = dbMovie.Title;
                transactionDetail.DateTime = dbSchedule.DateTime;
                transactionDetail.Theater = dbSchedule.Theater;
                transactionDetail.TicketPrice = 0;
                transactionDetail.Transaction = dbTransaction;

                // Set the selected seat
                transactionDetail.Seat = selectedSeat;

                // Add the transactionDetail to the database
                _context.Add(transactionDetail);
                await _context.SaveChangesAsync();

                QuantityCount++;

                if (transactionDetail.Transaction.TicketCount == QuantityCount)
                {
                    TempData.Remove("QuantityCount");
                    return RedirectToAction("Checkout", "Transaction",  new { transactionID = transactionDetail.Transaction.TransactionID, scheduleID = transactionDetail.Schedules.ScheduleId, transactionDetail = transactionDetail});
                }
                else
                {

                    TempData["QuantityCount"] = QuantityCount;
                    // Redirect to the same Create method with updated QuantityCount
                    return RedirectToAction("Create", new
                    {
                        transactionID = transactionDetail.Transaction.TransactionID,
                        scheduleID,
                        quantityCount = QuantityCount
                    });

                }

            }
            catch (Exception ex)
            {
                // Log the exception for further analysis
                Console.WriteLine(ex.ToString());

                ViewBag.AllSeats = GetSeatSelectList(transactionDetail);

                // Set the error message to be displayed on the website
                ModelState.AddModelError("", $"An error occurred while processing your request. Details: {ex}");

                return View(transactionDetail);
            }

        }





        // POST: TransactionDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionDetailID,Movie,Seat,SeniorDiscount,TuesdayDiscount,DateTime,Theater,TicketPrice,PopcornPoints")] TransactionDetail transactionDetail)
        {
            if (id != transactionDetail.TransactionDetailID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transactionDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionDetailExists(transactionDetail.TransactionDetailID))
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
            return View(transactionDetail);
        }

        // GET: TransactionDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TransactionDetails == null)
            {
                return NotFound();
            }

            var transactionDetail = await _context.TransactionDetails
                .FirstOrDefaultAsync(m => m.TransactionDetailID == id);
            if (transactionDetail == null)
            {
                return NotFound();
            }

            return View(transactionDetail);
        }

        // POST: TransactionDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TransactionDetails == null)
            {
                return Problem("Entity set 'AppDbContext.TransactionDetails'  is null.");
            }
            var transactionDetail = await _context.TransactionDetails.FindAsync(id);
            if (transactionDetail != null)
            {
                _context.TransactionDetails.Remove(transactionDetail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionDetailExists(int id)
        {
          return (_context.TransactionDetails?.Any(e => e.TransactionDetailID == id)).GetValueOrDefault();
        }





        private SelectList GetSeatSelectList(TransactionDetail transactionDetail)
        {
            // Fetch all seats for the specific schedule
            List<string> allSeats = new List<string>
    {
        "A1", "A2", "A3", "A4", "A5",
        "B1", "B2", "B3", "B4", "B5",
        "C1", "C2", "C3", "C4", "C5",
        "D1", "D2", "D3", "D4", "D5"
    };

            // Fetch the list of taken seats for the specific schedule
            var takenSeats = _context.TransactionDetails
                .Where(td => td.Schedules == transactionDetail.Schedules)
                .Select(td => td.Seat)
                .ToList();

            // Find the available seats
            var availableSeats = allSeats.Except(takenSeats).ToList();

            // Create a SelectList with the available seats
            SelectList slAvailableSeats = new SelectList(availableSeats);

            return slAvailableSeats;
        }




    }
}
