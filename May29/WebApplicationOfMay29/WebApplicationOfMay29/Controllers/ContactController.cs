using Microsoft.AspNetCore.Mvc;
using WebApplicationOfMay29.Models;

namespace WebApplicationOfMay29.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = $"Thank you, {model.Name}. Your message has been received.";
                ModelState.Clear(); // Clear form after submit
            }

            return View();
        }
    }
}
