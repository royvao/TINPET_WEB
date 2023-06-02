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
        public IActionResult AdvAndDisadv()
        {
            return View();
        }
        public IActionResult Firebase()
        {
            return View();
        }
        public IActionResult JetpackCompose()
        {
            return View();
        }
    }
}
