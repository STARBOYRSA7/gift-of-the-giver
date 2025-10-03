using Microsoft.AspNetCore.Mvc;
using gift_of_the_giver.Models;
using System.Collections.Generic;

namespace gift_of_the_giver.Controllers
{
    public class VolunteerController : Controller
    {
        private static List<VolunteerModel> Volunteers = new();

        // Redirect Index to Register page
        public IActionResult Index() => RedirectToAction("Register");

        // GET: display form and table
        public IActionResult Register()
        {
            return View(Volunteers);
        }

        // POST: handle form submission
        [HttpPost]
        public IActionResult Register(VolunteerModel model)
        {
            if (ModelState.IsValid)
            {
                Volunteers.Add(model);
                ViewBag.Message = "Volunteer registered successfully!";
            }
            return View(Volunteers);
        }
    }
}
