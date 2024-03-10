using Microsoft.AspNetCore.Mvc;
using Poco.UserModule.MVC.Contexts;
using Poco.UserModule.MVC.Entities;
using Poco.UserModule.MVC.Models;

namespace Poco.UserModule.MVC.Controllers
{
	public class RoleController : Controller
	{
		private Context context { set; get; }
		public RoleController(Context context)
		{
			this.context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult List()
		{
			var roles = this.context.roles.Select(p => new RoleViewModel
			{
				Name = p.Name,
				DtCreated = p.CreatedAt,
				Id = p.Id
			}).ToList();
			return Ok(new {data = roles});
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		[ActionName("Create")]
		public IActionResult CreateAction(RoleCreateViewModel model)
		{
			if (ModelState.IsValid)
			{
				Roles roles = new Roles()
				{
					Name= model.Name
				};
				context.Add(roles);
				context.SaveChanges();
				return RedirectToAction("Index","Role");
			}
			return View(model);
		}
	}
}
