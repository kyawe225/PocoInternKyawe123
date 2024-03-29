﻿namespace Poco.UserModule.MVC.Models
{
	public class RoleViewModel
	{
		public string Id { set; get; }
		public string Name { set; get; }
		public DateTime DtCreated { set; get; }
		public string Action { set; get; }
	}
	public class RoleCreateViewModel
	{
		public string Name { set; get; }
		public List<string> PermissionList { set; get; } = Enumerable.Empty<string>().ToList();
    }
}
