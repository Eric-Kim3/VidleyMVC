using System.Collections.Generic;
using System.Web.Mvc;
using VidleyMVC.Models;

namespace VidleyMVC.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movieList = GetMovies();

            return View(movieList);
        }

        //Init Movie Title
        private IEnumerable<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "Iron Man"},
                new Movie { Id = 2, Title = "Advenger"},
                new Movie { Id = 3, Title = "Hulk"},
                new Movie { Id = 4, Title = "Captain America"}
            };
            return movies;

        }
    }
}