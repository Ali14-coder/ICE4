using Microsoft.AspNetCore.Mvc;

namespace PROG_MVC_ICE4.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string? test = null)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
