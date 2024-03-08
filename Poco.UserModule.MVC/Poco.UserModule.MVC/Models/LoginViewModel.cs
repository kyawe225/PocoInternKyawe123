namespace Poco.UserModule.MVC.Models
{
	public class LoginViewModel
	{
		public string Email { set; get; }
		public string Password { set; get; }
		public Boolean IsRememberMe { set; get; } = false;
	}
}
