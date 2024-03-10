using Poco.UserModule.MVC.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poco.UserModule.MVC.Models
{
    public class UserCreateViewModel
    {
        public string Name { set; get; }
        public string UserName { set; get; }
        public string RoleId { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Password { set; get; }
        public string Gender { set; get; }
        
        
    }

    public class UserViewModel8 : UserCreateViewModel
    {
        public string Id { set; get; }
        public string Action { set; get; }
        public DateTime JoinedAt { set; get; }
        public string RoleName { set; get; }
        public bool IsActive { set; get; }
    }

    public class  UserUpdateViewModel : UserCreateViewModel
    {
        public string Id { set; get; }
        public bool IsActive { set; get; }
    }
}
