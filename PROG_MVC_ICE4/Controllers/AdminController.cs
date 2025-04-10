using Microsoft.AspNetCore.Mvc;

namespace PROG_MVC_ICE4.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
