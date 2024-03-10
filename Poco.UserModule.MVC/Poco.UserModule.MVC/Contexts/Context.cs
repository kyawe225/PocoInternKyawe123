using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Poco.UserModule.MVC.Entities;
using Poco.UserModule.MVC.Seeders;

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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new FeatureConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new RolePermissionConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
