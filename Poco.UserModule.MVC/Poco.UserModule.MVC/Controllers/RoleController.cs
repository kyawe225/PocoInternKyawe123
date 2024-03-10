using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
		[HttpGet]
		public IActionResult Index()
		{
			if (AuthChecker.IsPassed(HttpContext, "Role", "View", context))
			{
				return View();
			}
			return RedirectToAction("Index", "Home");
		}
		[HttpGet]
		public IActionResult List()
		{
			var roles = this.context.roles.Select(p => new RoleViewModel
			{
				Name = p.Name,
				DtCreated = p.CreatedAt,
				Id = p.Id,
				Action = $"<span href='{this.Url.Action("Delete", "Role", new { Id = p.Id })}' class='btn btn-danger delete'> Delete </span> <a href='{this.Url.Action("Edit", "Role", new { Id = p.Id })}' class='btn btn-secondary'> Edit </a>"
			}).ToList();
			return Ok(new { data = roles });
		}
		[HttpGet]
		public IActionResult Create()
		{
			if (AuthChecker.IsPassed(HttpContext, "Role", "Create", context))
			{
				var i = context.permissions.Include(p => p.Features).GroupBy(p => p.Name).Select(p => new
				{
					Key = p.Key,
					Children = p.ToList()
				}).ToList();
				ViewBag.permission = i;
				return View(new RoleCreateViewModel());
			}
			return RedirectToAction("Index", "Home");
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
					Name = model.Name
				};
				ICollection<RolePermissions> permissions = new List<RolePermissions>();
				foreach (var b in model.PermissionList)
				{
					permissions.Add(new RolePermissions
					{
						Name = Guid.NewGuid().ToString(),
						RoleId = roles.Id,
						PermissionId = b
					});
				}
				context.Add(roles);
				context.AddRange(permissions);
				context.SaveChanges();
                TempData["SuccessMessage"] = "Role Created Successfully";
                return RedirectToAction("Index", "Role");
			}
			var i = context.permissions.Include(p => p.Features).GroupBy(p => p.Name).Select(p => new
			{
				Key = p.Key,
				Children = p.ToList()
			}).ToList();
			ViewBag.permission = i;
			return View(model);
		}

		[HttpGet("[controller]/edit/{Id}")]
		public IActionResult Update(string Id)
		{
			if (AuthChecker.IsPassed(HttpContext, "Role", "Update", context))
			{
				var role = context.roles.Where(p => p.Id == Id).Include(p => p.RolePermissions).Select(p => new RoleCreateViewModel
				{
					Name = p.Name,
					PermissionList = p.RolePermissions.Select(p => p.PermissionId).ToList()
				}).FirstOrDefault();
				if (role == null)
				{
                    TempData["ErrorMessage"] = "Role Not Found";
                    return RedirectToAction("Index", "Role");
                }
				var i = context.permissions.Include(p => p.Features).GroupBy(p => p.Name).Select(p => new
				{
					Key = p.Key,
					Children = p.ToList()
				}).ToList();
				ViewBag.permission = i;
				return View("Create", role);
			}
			return RedirectToAction("Index", "Home");
	}
		[HttpPost("[controller]/edit/{Id}")]
		[ValidateAntiForgeryToken]
		[ActionName("Update")]
		public IActionResult Update(string Id, RoleCreateViewModel model)
		{
			if (ModelState.IsValid)
			{
				var role = context.roles.Where(p => p.Id == Id).Include(p => p.RolePermissions).FirstOrDefault();
				if (role == null)
				{
                    TempData["ErrorMessage"] = "Role Not Found";
                    return RedirectToAction("Index", "Role");
                }
				context.RemoveRange(role.RolePermissions);
				ICollection<RolePermissions> permissions = new List<RolePermissions>();
				role.UpdatedAt = DateTime.UtcNow;
				role.Name = model.Name;
				foreach (var b in model.PermissionList)
				{
					permissions.Add(new RolePermissions
					{
						Name = Guid.NewGuid().ToString(),
						RoleId = role.Id,
						PermissionId = b
					});
				}
				context.Update(role);
				context.AddRange(permissions);
				context.SaveChanges();
                TempData["SuccessMessage"] = "Role Updated Successfully";
                return RedirectToAction("Index", "Role");
			}
			var i = context.permissions.Include(p => p.Features).GroupBy(p => p.Name).Select(p => new
			{
				Key = p.Key,
				Children = p.ToList()
			}).ToList();
			ViewBag.permission = i;
			return View(model);
		}

		[HttpPost("[controller]/delete/{Id}")]
		[ValidateAntiForgeryToken]
		[ActionName("Delete")]
		public IActionResult Delete(string Id, RoleCreateViewModel model)
		{
			if (AuthChecker.IsPassed(HttpContext, "Role", "Delete", context))
			{
				if (ModelState.IsValid)
				{
					var role = context.roles.Where(p => p.Id == Id).Include(p => p.RolePermissions).FirstOrDefault();
					if (role == null)
					{
                        TempData["ErrorMessage"] = "Role Not Found";
                        return RedirectToAction("Index", "Role");
                    }
					context.RemoveRange(role.RolePermissions);
					context.Remove(role);
					context.SaveChanges();
					TempData["SuccessMessage"] = "Role Successfully Deleted";
				}
				TempData["ErrorMessage"] = "Role Not Successfully Deleted";
				return RedirectToAction("Index", "Role");
			}
			return RedirectToAction("Index", "Home");
		}
	}
}
