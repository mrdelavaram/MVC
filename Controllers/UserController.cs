using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UserController(ILogger<HomeController> logger)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public string GetName()
        {
            return "Masoud";
        }
        public string GetName1(string name)
        {

            return name;
        }
        public string GetName2(string fname, string lname, int age)
        {
            return fname + " " + lname + " age " + age;
        }
        public string GetName3(string name, string family, int age)
        {
            return $"{name} {family} age is {age}";
        }
        private string MyPrivate()
        {
            return "private method";
        }
        public IActionResult GetName4()
        {
            return View();
        }
        public IActionResult GetName5(string name)
        {
            return View(name);
        }
    }
}
