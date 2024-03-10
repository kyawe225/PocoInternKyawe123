using Microsoft.AspNetCore.Mvc;
using Poco.UserModule.MVC.Contexts;
using Poco.UserModule.MVC.Entities;
using Poco.UserModule.MVC.Models;
using System.Runtime.CompilerServices;

namespace Poco.UserModule.MVC.Controllers
{
	public class PermissionController : Controller
	{
		private readonly Context _context;
		public PermissionController(Context context)
		{
			_context = context;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View(new PermissionFeature());
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		[ActionName("Index")]
		public async Task<IActionResult> Save(PermissionFeature model)
		{
			if (ModelState.IsValid)
			{
				IEnumerable<Features> features = new List<Features>()
				{
					new Features
					{
						Name="Create"
					},
					new Features
					{
						Name="Update"
					},
					new Features
					{
						Name="Delete"
					},
					new Features
					{
						Name="View"
					}
				};

				_context.AddRange(features);
				//_context.Add(permission);
				await _context.SaveChangesAsync();
			}
			return View(model);
		}
	}
}
