using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeamBoss.GAC.Vitality.AspCore.Controllers
{
    public class HeadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Achievements()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }
    }
}