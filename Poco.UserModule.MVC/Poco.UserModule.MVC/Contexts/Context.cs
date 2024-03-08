using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Poco.UserModule.MVC.Entities;

namespace Poco.UserModule.MVC.Contexts
{
	public class Context:DbContext
	{
		public Context(DbContextOptions<Context> options):base(options)
		{
			
		}
		public DbSet<Features> features { set; get; }
		public DbSet<Permissions> permissions { set; get; }
		public DbSet<Roles> roles { set; get; }
		public DbSet<RolePermissions> rolePermissions { set; get; }
		public DbSet<AdminUser> adminUsers { set; get; }
	}
}
