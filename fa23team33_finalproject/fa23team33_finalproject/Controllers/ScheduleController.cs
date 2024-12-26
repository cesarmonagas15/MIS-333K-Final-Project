using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa23team33_finalproject.DAL;
using fa23team33_finalproject.Models;
using Microsoft.AspNetCore.Authorization;

namespace fa23team33_finalproject.Controllers
{


    public class ScheduleController : Controller
    {
        private readonly AppDbContext _context;

        public ScheduleController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Schedule
        public async Task<IActionResult> Index()
        {


            List<Schedule> schedules = await _context.Schedules
                                            .Include(s => s.Movies)
                                            .ToListAsync();

            return View(schedules);



            //return _context.Schedules != null ? 
            //              View(await _context.Schedules.ToListAsync()) :
            //              Problem("Entity set 'AppDbContext.Schedules'  is null.");
        }

        // GET: Schedule/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .FirstOrDefaultAsync(m => m.ScheduleId == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        [Authorize(Roles = "Manager")]
        // GET: Schedule/Create
        public IActionResult Create()
        {
            ViewBag.AllMovies = new SelectList(_context.Movies, "MovieID", "Title");
            return View();
        }



        // POST: Schedule/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Manager")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScheduleId,DateTime,Theater,SpecialEvent,MovieID")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                // Ensure MovieID is not 0
                if (schedule.Movies.MovieID != 0)
                {
                    // Fetch the selected movie using the provided MovieID
                    Movie dbMovie = await _context.Movies.FindAsync(schedule.Movies.MovieID);

                    // Set the Movies property of the schedule
                    schedule.Movies = dbMovie;

                    _context.Add(schedule);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("MovieID", "Please select a movie.");
                }
            }

            // If ModelState is not valid, repopulate the ViewBag
            ViewBag.AllMovies = new SelectList(_context.Movies, "MovieID", "Title");

            return View(schedule);
        }



        [Authorize(Roles = "Manager")]
        // GET: Schedule/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return View(schedule);
        }

        // POST: Schedule/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Manager")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScheduleId,DateTime,Theater,Price,SpecialEvent")] Schedule schedule)
        {
            if (id != schedule.ScheduleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.ScheduleId))
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
            return View(schedule);
        }

        // GET: Schedule/Delete/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .FirstOrDefaultAsync(m => m.ScheduleId == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedule/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Manager")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Schedules == null)
            {
                return Problem("Entity set 'AppDbContext.Schedules'  is null.");
            }
            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule != null)
            {
                _context.Schedules.Remove(schedule);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
          return (_context.Schedules?.Any(e => e.ScheduleId == id)).GetValueOrDefault();
        }

        private SelectList GetAllMMoviesSelectList()
        {
            //Get the list of months from the database
            List<Movie> monthList = _context.Movies.ToList();

            //add a dummy entry so the user can select all months

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList movieList = new SelectList(monthList.OrderBy(m => m.Title), "MonthID", "MonthName");

            //return the electList
            return movieList;
        }
    }
}
