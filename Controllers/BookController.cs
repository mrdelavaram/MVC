using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication7.Models;
using WebApplication7.Models.Book;

namespace WebApplication7.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public BookController(ILogger<HomeController> logger)
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
        [HttpGet]
        public IActionResult RegisterName()
        {
            var model = new RegisterNameViewModel();
            model.Name = "GetBook";
            return View(model);
        }

        [HttpPost]
        public IActionResult RegisterName(RegisterNameViewModel model)
        {

            return View();
        }
        [HttpGet]
        public IActionResult RegisterFile()
        {
            var model = new RegisterNameViewModel();
            return View(model);
                }
        [HttpPost]
        public IActionResult RegisterFile(RegisterNameViewModel model)
        {
            using (var ms=new MemoryStream())
            {
                NewMethod(model, ms);
                var fileBytes = ms.ToArray();
                string s = Convert.ToBase64String(fileBytes);
                model.FileBase64 = s;
            }
            return View();
        }

        private static void NewMethod(RegisterNameViewModel model, MemoryStream ms)
        {
            model.file.CopyTo(ms);
        }
    }

}
