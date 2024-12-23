﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Alliance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Alliance.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public ActionResult About()
		{
			return View();
		}
		public ActionResult Courses()
		{
			return View();
		}
		public ActionResult News()
		{
			return View();
		}
		public ActionResult Carrer()
		{
			return View();
		}
		public ActionResult Gallery()
		{
			return View();
		}
		public ActionResult Contact()
		{
			return View();
		}
		public ActionResult Register()
		{
			return View();
		}
		public IActionResult Login()
		{
			return View();
		}
		public ActionResult Facilities()
		{
			return View();
		}
        public ActionResult Subject()
        {
            return View();
        }
        public ActionResult Teacher()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
