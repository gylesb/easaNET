using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using easaNET.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace easaNET.Controllers
{
	public class CrewController : Controller
	{
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Crew crew)
		{

			return RedirectToAction("Result", crew);
		}

		public IActionResult Result(Crew crew)
		{
			return View(crew);
		}
	}
}
