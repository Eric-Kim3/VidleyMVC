using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VidleyMVC.Models;
using VidleyMVC.ViewModel;

namespace VidleyMVC.Controllers
{
    public class MovieController : Controller
    {
        public ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();

        }

        // GET: Movie
        public ActionResult Index()
        {
            var movieList = _context.Movies.Include(m => m.GenreType).ToList();

            return View(movieList);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.GenreType).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieFormViewModel(movie)
            {

                GenreTypes = _context.GenreTypes.ToList()
            };
            return View("MovieForm", viewModel);
            //return View(movie);

        }

        public ActionResult New()
        {
            var genreTypes = _context.GenreTypes.ToList();
            var viewModel = new MovieFormViewModel()
            {
                GenreTypes = genreTypes
            };
            return View("MovieForm", viewModel);
        }

        //public ActionResult Edit(Movie movie)
        //{

        //    return View("MovieForm", )
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);

            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Title = movie.Title;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreTypeId = movie.GenreTypeId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }
    }
}