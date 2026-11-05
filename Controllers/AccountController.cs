using Microsoft.AspNetCore.Mvc;
using Quiz_67127924_Chanapol.Models;
using System.Collections.Generic;

namespace Quiz_67127924_Chanapol.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            
            TempData["UserId"] = model.UserId; 
            return RedirectToAction("Index", "Student");
        }

        public IActionResult UserList()
        {
            
           
            
            var users = new List<UserViewModel>
            {
                new UserViewModel { UserId = "1", FullName = "asdasd" },
                new UserViewModel { UserId = "2", FullName = "asdasd" },
                new UserViewModel { UserId = "3", FullName = "asdasd" },
                new UserViewModel { UserId = "4", FullName = "asdasd" },
                new UserViewModel { UserId = "5", FullName = "asdasd" },
                new UserViewModel { UserId = "6", FullName = "asdasd" },
                new UserViewModel { UserId = "7", FullName = "asdasd" },
                new UserViewModel { UserId = "8", FullName = "asdasd" }
            };
            return View(users);
        }
    }
}