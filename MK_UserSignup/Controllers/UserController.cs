using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MK_UserSignup.Models;

namespace MK_UserSignup.Controllers
{
    public class UserController : Controller
    {
        private static string error = null;
        public IActionResult Index()
        {
            ViewBag.users = UserData.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.title = "Add User";
            ViewBag.error = error;

            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verifyPassword)
        {
            if ((string.IsNullOrEmpty(user.Password)) || (string.IsNullOrEmpty(verifyPassword)))
            {
                error = "Passwords cannot be empty";
                return Redirect("/User/Add");
            }
            if (user.Password != verifyPassword)
            {
                error = "Passwords do not match";
                return Redirect("/User/Add");
            }
            else
            {
                UserData.Add(user);
            }

            error = null;

            return Redirect("/User");
        }

        [HttpGet]
        public IActionResult DisplayDetail(int userId)
        {
            ViewBag.title = "User Detail";
            ViewBag.user = UserData.GetById(userId);
            return View();
        }
    }
}