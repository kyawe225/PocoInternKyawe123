namespace Poco.UserModule.MVC.Entities
{
	public class BaseModel
	{
		public string Id { set; get; }
		public DateTime CreatedAt { set; get; }
		public DateTime UpdatedAt { set; get; }
		public bool IsDeleted { set; get; }
	}
}
