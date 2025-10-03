using Microsoft.AspNetCore.Mvc;
using gift_of_the_giver.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace gift_of_the_giver.Controllers
{
    public class AccountController : Controller
    {
        private static List<RegisterModel> Users = new();

        // Register page
        public IActionResult Register() => View(Users);

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Users.Add(model);
                return RedirectToAction("Login");
            }
            return View(Users);
        }

        // Login page
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            var user = Users.Find(u => u.Email == Email && u.Password == Password);
            if (user != null)
            {
                HttpContext.Session.SetString("UserEmail", user.Email);
                HttpContext.Session.SetString("Username", user.Username);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Message = "Invalid email or password!";
            return View();
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
