using Microsoft.AspNetCore.Mvc;

namespace STC_Picks.Controllers
{
    public class ArchiveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Wimbledon2023()
        {
            return View();
        }
        public IActionResult USOpen2023()
        {
            return View();
        }
        public IActionResult AustralianOpen2024()
        {
            return View();
        }
    }
}
