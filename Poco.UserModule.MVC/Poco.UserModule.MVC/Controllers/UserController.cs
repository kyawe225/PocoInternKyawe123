using Microsoft.AspNetCore.Mvc;

namespace Poco.UserModule.MVC.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
