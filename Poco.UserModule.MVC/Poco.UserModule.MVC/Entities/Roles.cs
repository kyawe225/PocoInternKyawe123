namespace Poco.UserModule.MVC.Entities
{
	public class Roles:BaseModel
	{
		public string Name { set; get; }
		public virtual ICollection<RolePermissions>? RolePermissions { set; get; }
	}
}
