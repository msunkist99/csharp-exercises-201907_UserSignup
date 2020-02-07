using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MK_UserSignup.Models;
using MK_UserSignup.ViewModels;

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
            //ViewBag.title = "Add User";
            //ViewBag.error = error;

            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            /*
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
            */

            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    Username = addUserViewModel.Username,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.Password
                };

                UserData.Add(user);
                return Redirect("/User");
           }

            return View(addUserViewModel);
        }

        [HttpGet]
        public IActionResult DisplayDetail(int userId)
        {
            User user = UserData.GetById(userId);

            AddUserViewModel addUserViewModel = new AddUserViewModel()
            {
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                UserId = user.UserId,
                CreateDateTime = user.CreateDateTime
            };

            return View(addUserViewModel);
        }
    }
}