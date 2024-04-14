using Microsoft.AspNetCore.Mvc;

namespace LDHShop.Controllers
{
	public class KhachHangController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
