using Microsoft.AspNetCore.Mvc;
using gift_of_the_giver.Models;
using System.Collections.Generic;

namespace gift_of_the_giver.Controllers
{
    public class DisasterController : Controller
    {
        private static List<DisasterModel> Reports = new();

        public IActionResult Index() => RedirectToAction("Report");

        public IActionResult Report() => View(Reports);

        [HttpPost]
        public IActionResult Report(DisasterModel model)
        {
            if (ModelState.IsValid)
            {
                Reports.Add(model);
                ViewBag.Message = "Incident reported successfully!";
            }
            return View(Reports);
        }
    }
}
