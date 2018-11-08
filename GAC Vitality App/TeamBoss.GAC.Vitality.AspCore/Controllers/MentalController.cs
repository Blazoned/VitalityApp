using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeamBoss.GAC.Vitality.AspCore.Controllers
{
	public class MentalController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult NikoNikocalendar()
		{
			return View();
		}
		public IActionResult MentalBuddy()
		{
			return View();
		}
	}
}
