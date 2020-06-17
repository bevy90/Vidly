using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer { Name = "John Doe", Id = 1},
            new Customer { Name = "Jane Smith", Id = 2}
        };

        public ActionResult Customers()
        {
            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Customer(int id)
        {
            Customer customer = customers.Find(delegate(Customer c)
            {
                return c.Id == id;
            });
            return View(customer);
        }

    }
}