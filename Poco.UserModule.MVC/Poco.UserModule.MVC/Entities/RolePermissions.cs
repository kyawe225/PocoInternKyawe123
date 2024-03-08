using System.ComponentModel.DataAnnotations.Schema;

namespace Poco.UserModule.MVC.Entities
{
	public class RolePermissions : BaseModel
	{
		public string Name
		{
			set; get;
		}
		public string RoleId { set; get; }
		[ForeignKey("RoleId")]
		public Roles Role { set; get; }
		public string PermissionId { set; get; }
		[ForeignKey("PermissionId")]
		public Permissions Permission { set; get; }
	}
}
