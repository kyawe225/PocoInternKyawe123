using Poco.UserModule.MVC.Contexts;
using Poco.UserModule.MVC.Entities;
using System.Security.Claims;

namespace Poco.UserModule.MVC
{
    public class AuthChecker
    {
        public static bool IsPassed(HttpContext httpContext,string PermissionName,string FeatureName,Context context)
        {
            var q=httpContext.User.Claims.FirstOrDefault(p=> p.Type== ClaimTypes.Role);
            if(q!= null)
            {
                return context.rolePermissions.Any(p => p.RoleId == q.Value && p.Permission.Name == PermissionName && p.Permission.Features.Name == FeatureName);
            }
            return false;
        }
    }
}
