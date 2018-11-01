using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeamBoss.GAC.Vitality.AspCore.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateRecept()
        {
            return View();
        }

        public IActionResult SearchRecepts()
        {
            return View();
        }

        public IActionResult ViewRecept()
        {
            return View();
        }

        public IActionResult RecipeReactions()
        {
            return View();
        }

        public IActionResult CalorieCounter()
        {
            return View();
        }
    }
}