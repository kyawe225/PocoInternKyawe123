using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Poco.UserModule.MVC.Contexts;
using Poco.UserModule.MVC.Entities;
using Poco.UserModule.MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Poco.UserModule.MVC.Controllers
{
    [Authorize]
	public class UserController : Controller
	{
		private readonly Context _context;
		public UserController(Context context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
            if (AuthChecker.IsPassed(HttpContext, "User","View",_context))
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public IActionResult List()
		{
			var data = _context.adminUsers.Where(p=> !p.IsDeleted).Include(p => p.Role).Select(p => new UserViewModel8
			{
				Name = p.Name,
				UserName = p.UserName,
				Email = p.Email,
				Phone = p.Phone,
				Address = p.Address,
				Gender = p.Gender == true ? "male" : "female",
				JoinedAt = p.CreatedAt,
				RoleName = p.Role.Name,
				IsActive = p.IsActive,
                Action=$"<span href='{this.Url.Action("Delete", "User", new { Id = p.Id })}' class='btn btn-danger delete'> Delete </span> <a href='{this.Url.Action("Edit", "User", new { Id = p.Id })}' class='btn btn-secondary'> Edit </a>"
			});
			return Ok(new {data = data});
		}

		[HttpGet]
		public IActionResult Create()
		{
            if (AuthChecker.IsPassed(HttpContext, "User", "Create", _context))
            {
                ViewBag.roleList = _context.roles.Where(p => !p.IsDeleted).Select(p => new SelectListItem
                {
                    Text = p.Name,
                    Value = p.Id
                }).ToList();
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
		[HttpPost]
		[ValidateAntiForgeryToken]
		[ActionName("Create")]
		public IActionResult CreateAction(UserCreateViewModel model)
		{
			if (ModelState.IsValid)
			{
				AdminUser user = new AdminUser()
				{
					Name = model.Name.Trim(),
					UserName = model.UserName.Trim(),
					Address = model.Address.Trim(),
					Password = model.Password.Trim(),
					RoleId = model.RoleId,
					Gender = model.Gender == "male" ? true : false,
					Email = model.Email.Trim(),
					Phone = model.Phone.Trim(),
					IsActive = true			
				};
				_context.Add(user);
				_context.SaveChanges();
                TempData["SuccessMessage"] = "User Created Successfully";
                return RedirectToAction("Index", "User");
			}
            ViewBag.roleList = _context.roles.Where(p => !p.IsDeleted).Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id
            }).ToList();
            return View(model);
		}
        [HttpGet("[controller]/edit/{Id}")]
        public IActionResult Edit(string Id)
        {
            if (AuthChecker.IsPassed(HttpContext, "User", "Update", _context))
            {
                UserUpdateViewModel? user = _context.adminUsers.Where(p => p.Id == Id && !p.IsDeleted).Select(p => new UserUpdateViewModel
                {
                    Name = p.Name.Trim(),
                    UserName = p.UserName.Trim(),
                    Address = p.Address.Trim(),
                    Password = "*********",
                    RoleId = p.RoleId,
                    Gender = p.Gender ? "male" : "female",
                    Email = p.Email.Trim(),
                    Phone = p.Phone.Trim(),
                    IsActive = true
                }).FirstOrDefault();

                if (user == null)
                {
                    TempData["ErrorMessage"] = "User Not Found";
                    return RedirectToAction("Index", "User");
                }
                ViewBag.roleList = _context.roles.Where(p => !p.IsDeleted).Select(p => new SelectListItem
                {
                    Text = p.Name,
                    Value = p.Id
                }).ToList();
                return View(user);
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost("[controller]/edit/{Id}")]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public IActionResult EditAction(string Id, UserCreateViewModel model)
        {
            AdminUser? user = _context.adminUsers.Where(p => p.Id == Id && !p.IsDeleted).FirstOrDefault();

            if (user == null)
            {
                TempData["ErrorMessage"] = "User Not Found";
                return RedirectToAction("Index", "User");
            }
            if (ModelState.IsValid)
            {
                user.Name = model.Name.Trim();
                user.UserName = model.UserName.Trim();
                user.Address = model.Address.Trim();
                user.Password = model.Password.Trim();
                user.RoleId = model.RoleId;
                user.Gender = model.Gender == "male" ? true : false;
                user.Email = model.Email.Trim();
                user.Phone = model.Phone.Trim();
                user.IsActive = true;
                _context.Update(user);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "User Updated Successfully";
                return RedirectToAction("Index", "User");
            }
            ViewBag.roleList = _context.roles.Where(p => !p.IsDeleted).Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id
            }).ToList();
            return View(model);
        }
        [HttpPost("[controller]/delete/{Id}")]
        [ActionName("Delete")]
        public IActionResult Delete(string Id)
        {
            if (AuthChecker.IsPassed(HttpContext, "User", "Delete", _context))
            {
                AdminUser? user = _context.adminUsers.Where(p => p.Id == Id && !p.IsDeleted).FirstOrDefault();
                if (user == null)
                {
                    TempData["ErrorMessage"] = "User Not Found";
                    return RedirectToAction("Index", "User");
                }
                if (ModelState.IsValid)
                {
                    user.IsDeleted = true;
                    _context.Update(user);
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "User Deleted Successfully";
                }
                return RedirectToAction("Index", "User");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
