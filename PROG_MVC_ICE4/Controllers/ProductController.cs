using Microsoft.AspNetCore.Mvc;

namespace PROG_MVC_ICE4.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cakes()
        {
            return View();
        }
       
    }
}
