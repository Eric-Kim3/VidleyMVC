using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VidleyMVC.Models;

namespace VidleyMVC.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customerList = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customerList);
        }
        //[Route("customers/detail/{id}")]
        public ActionResult Details(int id)
        {
            //selects single customer in the GetCustomers when customer.Id is equal to id
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);

        }

    }
}