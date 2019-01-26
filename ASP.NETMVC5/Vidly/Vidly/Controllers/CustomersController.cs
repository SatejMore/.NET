using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers.ToList());
        }

        public ActionResult CustomerDetails(int id)
        {
            var customers = GetCustomers().ToList();
            if (customers.Exists(c => c.Id == id))
            {
                return View(customers[id - 1]);
            }
            return HttpNotFound();
        }

        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name="Satej" },
                new Customer {Id = 2, Name="Temp" }
            };
            return customers;
        }

    }
}