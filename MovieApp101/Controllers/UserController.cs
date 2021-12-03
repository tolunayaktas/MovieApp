using Microsoft.AspNetCore.Mvc;
using MovieApp101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp101.Controllers
{
    public class UserController : Controller
    {
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(UserModel model)
        {
            
            return View();
        }
        [AcceptVerbs("GET","POST")]
        public IActionResult VerifyUserName(string UserName)
        {
            var users = new List<string> { "tolunayaktas", "alpaktas" };
            if (users.Any(i => i == UserName))
            {
                return Json($"{UserName} zaten alınmış.");
            }
            return Json(true);
        }
    }
}
