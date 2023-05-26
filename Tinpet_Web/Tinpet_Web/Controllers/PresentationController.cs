using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tinpet_Web.Controllers
{
    public class PresentationController : Controller
    {
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Proyect()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
