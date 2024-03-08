using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Poco.UserModule.MVC.Models;
using System.Security.Claims;

namespace Poco.UserModule.MVC.Controllers
{
	public class AuthController : Controller
	{
		public IActionResult Login()
		{
			return View(new LoginViewModel());
		}
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		[ActionName("Login")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> LoginAction(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				Claim[] claims = new Claim[]
				{
					new Claim(ClaimTypes.Name, "kyaw"),
					new Claim(ClaimTypes.Email , model.Email),
				};
				ClaimsIdentity identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
				ClaimsPrincipal principal = new ClaimsPrincipal(identity);
				await HttpContext.SignInAsync(principal, new AuthenticationProperties() { IsPersistent = true});
				return RedirectToAction("Index", "Home");
			}
			return View(model);
		}
	}
}
