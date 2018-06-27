using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _contex;
        public CustomersController()
        {
            _contex = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }

        public ActionResult New()
        {
            return View();
        }
        public ViewResult Index()
        {
            var customers = _contex.Customers.Include(c =>c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer =_contex.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}