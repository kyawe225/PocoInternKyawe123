using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Poco.UserModule.MVC.Contexts;
using Poco.UserModule.MVC.Models;
using System.Security.Claims;

namespace Poco.UserModule.MVC.Controllers
{
	public class AuthController : Controller
	{
		private readonly Context _context;
		public AuthController(Context context)
		{
			_context = context;
		}
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
				var user=_context.adminUsers.Where(p => p.Email == model.Email && p.Password == model.Password).Include(p=> p.Role).FirstOrDefault();
				if (user == null)
				{
					TempData["ErrorMessage"] = "User Credential is Wrong";
					return View(model);
				}
				Claim[] claims = new Claim[]
				{
					new Claim(ClaimTypes.Name, user.Name),
					new Claim(ClaimTypes.Email , user.Email),
					new Claim(ClaimTypes.Role , user.Role.Id),
					new Claim(ClaimTypes.GivenName,user.UserName)
				};
				ClaimsIdentity identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
				ClaimsPrincipal principal = new ClaimsPrincipal(identity);
				await HttpContext.SignInAsync(principal, new AuthenticationProperties() { IsPersistent = true});
				return RedirectToAction("Index", "Home");
			}
			return View(model);
		}
        [HttpPost]
        [ActionName("Logout")]
        [ValidateAntiForgeryToken]
		[Authorize]
        public async Task<IActionResult> Logout(LoginViewModel model)
        {
			await HttpContext.SignOutAsync();
			return RedirectToAction("Login","Auth");
        }
    }
}
