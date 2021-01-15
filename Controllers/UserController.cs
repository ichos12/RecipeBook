using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using RecipeBook.Models;

namespace RecipeBook.Controllers
{
    public class UserController : Controller
    {
        private RecipeBookContext db;
        public UserController(RecipeBookContext context)
        {
            db = context;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Profile(int? Id)
        {
            if (Id == null) return RedirectToAction("Index", "Home");
            User user = db.Users.Find(Id);
            return View(user);
        }
    }
}
