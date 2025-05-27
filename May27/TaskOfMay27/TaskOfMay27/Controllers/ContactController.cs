using Microsoft.AspNetCore.Mvc;

namespace TaskOfMay27.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(string name, string email, string message)
        {
            ViewBag.Message = "Thank you for contacting us!";
            return View("Index");
        }
    }
}
