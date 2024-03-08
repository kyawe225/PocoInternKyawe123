using System.ComponentModel.DataAnnotations.Schema;

namespace Poco.UserModule.MVC.Entities
{
	public class Permissions:BaseModel
	{
		public string Name { set; get; }
		public string FeaturesId { set; get; }
		[ForeignKey("FeaturesId")]
		public Features Features { set; get; }
	}
}
