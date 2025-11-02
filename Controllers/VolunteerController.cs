using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using gift_of_the_giver.Models;
using System.Collections.Generic;

namespace gift_of_the_giver.Controllers
{
    public class VolunteerController : Controller
    {
        private static List<VolunteerModel> Volunteers = new List<VolunteerModel>();

        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
                return RedirectToAction("Login", "Account");

            return View(Volunteers);
        }

        [HttpPost]
        public IActionResult Index(VolunteerModel model)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
                return RedirectToAction("Login", "Account");

            if (ModelState.IsValid)
            {
                Volunteers.Add(model);
                ViewBag.Message = "Volunteer added successfully!";
            }
            return View(Volunteers);
        }
    }
}
