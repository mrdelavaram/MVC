﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
