using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Models;

namespace RecipeBook.Controllers
{
    public class RecipeController : Controller
    {
        private RecipeBookContext db;
        public RecipeController(RecipeBookContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FirstDishes()
        {
            return View(db.Recipes.ToList());
        }
        public IActionResult SecondDishes()
        {
            return View(db.Recipes.ToList());
        }
        public IActionResult Desserts()
        {
            return View(db.Recipes.ToList());
        }
        public IActionResult Recipe(int? Id)
        {
            if (Id == null) return RedirectToAction("Index", "Home");
            Recipe recipe = db.Recipes.Find(Id);
            return View(recipe);
        }
    }
}
