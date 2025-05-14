using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            return "This is the Index Action";
        }

        public string method1()
        {
            return "This is the method 1";
        }

        public string method2()
        {
            return "This is the method 2";
        }
    }
}

// ON EXECUTION, WE GET THE WEBPAGE.
// THEN CHANGE THE URL TO "localhost:5095/home[CONTROLLER]/method1[ACTION]
// NOW WE CAN SEE THE CHANGES