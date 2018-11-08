using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeamBoss.GAC.Vitality.AspCore.Controllers
{
    public class MovementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateChallenge()
        {
            return View();
        }

        public IActionResult Invite()
        {
            return View();
        }
    }
}