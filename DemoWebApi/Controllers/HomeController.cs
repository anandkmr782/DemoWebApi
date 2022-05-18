using DemoWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoWebApi.Controllers
{
    public class HomeController : Controller
    {               

        public IActionResult Index()
        {
            return View();
        }
    }
}