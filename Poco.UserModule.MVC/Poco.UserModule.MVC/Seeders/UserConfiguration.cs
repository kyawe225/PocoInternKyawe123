using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poco.UserModule.MVC.Entities;

namespace Poco.UserModule.MVC.Seeders
{
    public class UserConfiguration:IEntityTypeConfiguration<AdminUser>
    {
        public void Configure(EntityTypeBuilder<AdminUser> builder)
        {
            builder.HasData(new AdminUser[]
            {
                new AdminUser
                {
                    RoleId = "2ab8d293-0e06-44a9-be5f-6d050e77f9be",
                    Name = "Hello",
                    UserName = "KZH",
                    Email = "hello@gmail.com",
                    Phone = "123456789",
                    Address = "Burma",
                    Gender = true,
                    IsActive = true,
                    Password = "12345"
                }
            });
        }
    }
}
