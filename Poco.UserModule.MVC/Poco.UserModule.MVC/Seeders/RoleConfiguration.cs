using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poco.UserModule.MVC.Entities;

namespace Poco.UserModule.MVC.Seeders
{
    public class RoleConfiguration:IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.HasData(new Roles[]
            {
                new Roles
                {
                    Id = "2ab8d293-0e06-44a9-be5f-6d050e77f9be",
                    Name="Admin",
                }
            });
        }
    }
}
