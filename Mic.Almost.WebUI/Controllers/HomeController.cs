using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Mic.Almost.BusinessInterfaces;

namespace Mic.Almost.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerManager _customerManager;

        public HomeController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        public async Task<ActionResult> Index()
        {
            var customers = await _customerManager.GetCustomersAsync();
            return View(customers);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}