using Microsoft.AspNetCore.Mvc;
using gift_of_the_giver.Models;
using System.Collections.Generic;

namespace gift_of_the_giver.Controllers
{
    public class DonationController : Controller
    {
        private static List<DonationModel> Donations = new();

        public IActionResult Index() => RedirectToAction("Submit");

        public IActionResult Submit() => View(Donations);

        [HttpPost]
        public IActionResult Submit(DonationModel model)
        {
            if (ModelState.IsValid)
            {
                Donations.Add(model);
                ViewBag.Message = "Donation submitted successfully!";
            }
            return View(Donations);
        }
    }
}
