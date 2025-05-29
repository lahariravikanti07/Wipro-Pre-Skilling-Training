using Microsoft.AspNetCore.Mvc;

namespace WebApplicationOfMay29.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
