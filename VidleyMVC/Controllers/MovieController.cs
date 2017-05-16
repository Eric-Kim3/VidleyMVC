using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VidleyMVC.Models;

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
            return View(movie);

        }

    }
}