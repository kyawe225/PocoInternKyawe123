namespace Poco.UserModule.MVC.Entities
{
	public class BaseModel
	{
		public string Id { set; get; }=Guid.NewGuid().ToString();
		public DateTime CreatedAt { set; get; } = DateTime.UtcNow;
		public DateTime UpdatedAt { set; get; } = DateTime.UtcNow;
		public bool IsDeleted { set; get; } = false;
	}
}
