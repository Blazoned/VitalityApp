﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace TeamBoss.GAC.Vitality.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            var feature = this.HttpContext.Features.Get<IExceptionHandlerFeature>();
            return View("~/Views/Shared/Error.cshtml", feature?.Error);
        }
    }
}