using fa23team33_finalproject.DAL;
using fa23team33_finalproject.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Humanizer;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace fa23team33_finalproject.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public ActionResult Index(String SearchString)
        {
            var query = from mv in _context.Movies
                        select mv;
            if (SearchString == null)
            {
                ViewBag.Allmovies = _context.Movies.Count();
                ViewBag.Selectedmovies = _context.Movies.Count();
                return View(_context.Movies.Include(m => m.Genre)
                    .Include(m => m.Reviews)
                    .ToList());
            }
            else if (SearchString != null)
            {
                query = query.Where(mv => mv.Title.Contains(SearchString) || mv.Tagline.Contains(SearchString));
            }
            List<Movie> SelectedMovies = query.Include(m => m.Genre).Include(m => m.Reviews).ToList();
            //Populate the view bag with a count of all movie postings
            ViewBag.Allmovies = _context.Movies.Count();
            //Populate the view bag with a count of selected movie postings
            ViewBag.SelectedMovies = SelectedMovies.Count();
            return View(SelectedMovies);
        }
        public IActionResult Details(int? id)
        {
            if (id == null) //MovieID not specified
            {
                return View("Error", new String[] { "MovieID not specified - which jop posting do you want to view ? " });
            }
            Movie Movie = _context.Movies.Include(m => m.Genre).FirstOrDefault(m => m.MovieID == id);
            if (Movie == null) //movie posting does not exist in database
            {
                return View("Error", new String[] { "movie posting not found in database" });
            }
            //if code gets this far, all is well
            return View(Movie);
        }
        public IActionResult DetailedSearch()
        {
            ViewBag.AllGenres = GetAllGenresSelectList();
            SearchViewModel svm = new SearchViewModel();
            return View();
        }
        private SelectList GetAllGenresSelectList()
        {
            //Get the list of months from the database
            List<Genre> GenreList = _context.Genre.ToList();

            //add a dummy entry so the user can select all months
            Genre SelectNone = new Genre() { GenreId = 0, GenreName = "All Genres" };
            GenreList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //GenreID and GenreName are the names of the properties on the Genre class
            //GenreID is the primary key
            SelectList GenreSelectList = new SelectList(GenreList.OrderBy(m => m.GenreId));

            //return the selectList
            return GenreSelectList;
        }
        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            var query = from mv in _context.Movies
                        select mv;
            //Title
            if (svm.SearchTitle != null)
            {
                query = query.Where(mv => mv.Title != null && mv.Title.Contains(svm.SearchTitle));
            }
            //Tagline

            if (svm.SearchTagline != null)
            {
                query = query.Where(mv => mv.Tagline != null && mv.Tagline.Contains(svm.SearchTagline));
            }
            //Genre - Drop Down
            if (svm.SelectedGenreId != 0)
            {
                query = query.Where(mv => mv.Genre.GenreId != null && mv.Genre.GenreId == svm.SelectedGenreId);
            }
            //Release Year
            if (svm.SearchReleaseYear != null)
            {
                query = query.Where(mv => mv.ReleaseYear != null && mv.ReleaseYear == svm.SearchReleaseYear);
            }
            //MPAA Rating
            if (svm.SelectedMPAARating != null)
            {
                query = query.Where(mv => mv.MPAArating != null && mv.MPAArating.Contains(svm.SelectedMPAARating));
            }
            //Customer Rating
            if (svm.SearchRating != null)

            {
                int searchRatingValue = svm.SearchRating;


                if (svm.SearchType == SearchType.GreaterThan)
                {
                    query = query.Where(mv => mv.Reviews.Any(review => review.Rating >= searchRatingValue));
                }
                if (svm.SearchType == SearchType.LessThan)
                {
                    query = query.Where(mv => mv.Reviews.Any(review => review.Rating <= searchRatingValue));
                }
            }

            List<Movie> SelectedMovies = query.ToList();
            //Populate the view bag with a count of all Movies
            ViewBag.AllMovies = _context.Movies.Count();
            //Populate the view bag with a count of selected Movies
            ViewBag.SelectedMovies = SelectedMovies.Count();
            return View("Index", SelectedMovies);
        }
    }
}




