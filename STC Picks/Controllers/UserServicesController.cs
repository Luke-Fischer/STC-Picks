using Microsoft.AspNetCore.Mvc;

namespace STC_Picks.Controllers
{
	public class UserServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
