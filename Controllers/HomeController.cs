using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace gift_of_the_giver.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserEmail") == null)
                return RedirectToAction("Login", "Account");

            return View();
        }

        public IActionResult Privacy()
        {
            if (HttpContext.Session.GetString("UserEmail") == null)
                return RedirectToAction("Login", "Account");

            return View();
        }
    }
}
