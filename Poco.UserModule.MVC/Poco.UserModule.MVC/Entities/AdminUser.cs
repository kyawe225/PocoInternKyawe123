using System.ComponentModel.DataAnnotations.Schema;

namespace Poco.UserModule.MVC.Entities
{
	public class AdminUser:BaseModel
	{
		public string Name { set; get; }
		public string UserName { set; get; }
		public string RoleId { set; get; }
		[ForeignKey("RoleId")]
		public virtual Roles? Role { set; get; }
		public string Phone { set; get; }
		public string Email { set; get; }
		public string Address { set; get; }
		public string Password { set; get; }
		public bool Gender { set; get; }
		public bool IsActive { set; get; }
	}
}
