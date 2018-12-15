using Microsoft.AspNetCore.Mvc;
using ProfBusWeb.Models;

namespace ProfBusWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(string Name, string Phone, string Address, string Text)
        {
            ViewData["Name"] = Name;
            return View();
        }
    }
}
