using Microsoft.AspNetCore.Mvc;

namespace LDHShop.Controllers
{
	public class HoaDonController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
