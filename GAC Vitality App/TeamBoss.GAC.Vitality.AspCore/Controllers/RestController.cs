using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeamBoss.GAC.Vitality.AspCore.Controllers
{
    public class RestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddSleep()
        {
            return View();
        }
    }
}