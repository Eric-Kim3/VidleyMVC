using System;
using System.Linq;
using System.Web.Http;
using VidleyMVC.Dtos;
using VidleyMVC.Models;

namespace VidleyMVC.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }

        //GET
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDTO newRental)
        {

            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);


            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();


            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not availale");
                movie.NumberAvailable--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }


            _context.SaveChanges();

            return Ok();
        }

    }
}
