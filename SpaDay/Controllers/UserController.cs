using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.username = newUser.Username;
            ViewBag.email = newUser.Email;
            ViewBag.dateJoined = newUser.Date;

            if (verify == newUser.Password)
            {
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords did not match. Please try again.";
                return View("Add");
            }
        }
    }
}
    