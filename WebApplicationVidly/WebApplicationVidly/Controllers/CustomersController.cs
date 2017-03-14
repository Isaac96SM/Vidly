using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationVidly.Models;

namespace WebApplicationVidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 0, Name = "Isaac Suárez" },
                new Customer { Id = 1, Name = "Judith Raïss" }
            };

            return View(customers);
        }
    }
}