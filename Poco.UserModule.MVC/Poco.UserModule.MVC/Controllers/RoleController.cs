using Microsoft.AspNetCore.Mvc;

namespace Poco.UserModule.MVC.Controllers
{
	public class RoleController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
