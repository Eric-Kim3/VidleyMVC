using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using VidleyMVC.Models;

namespace VidleyMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customerList = GetCustomers();
            return View(customerList);
        }
        //[Route("customers/detail/{id}")]
        public ActionResult Details(int id)
        {
            //selects single customer in the GetCustomers when customer.Id is equal to id
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
            
        }

        //Create customer lists
        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "John Doe"},
                new Customer {Id = 2, Name = "David Smith"},
                new Customer {Id = 3, Name = "Steve Johnson"},
                new Customer {Id = 4, Name = "Brian White"}
            };
            return customers;
        }
    }
}