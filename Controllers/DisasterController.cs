using Microsoft.AspNetCore.Mvc;
using gift_of_the_giver.Models;
using System.Collections.Generic;

namespace gift_of_the_giver.Controllers
{
    public class DisasterController : Controller
    {
        // Temporary in-memory list
        private static List<DisasterModel> disasters = new List<DisasterModel>();

        // Show list + form
        public IActionResult Index()
        {
            return View(disasters);
        }

        // Handle form POST
        [HttpPost]
        public IActionResult Report(DisasterModel model)
        {
            if (ModelState.IsValid)
            {
                disasters.Add(model);
                TempData["Message"] = "Disaster report submitted successfully!";
                return RedirectToAction("Index");
            }
            return View("Index", disasters);
        }
    }
}
