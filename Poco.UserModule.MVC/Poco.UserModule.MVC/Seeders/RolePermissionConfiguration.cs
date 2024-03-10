using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poco.UserModule.MVC.Entities;

namespace Poco.UserModule.MVC.Seeders
{
    public class RolePermissionConfiguration:IEntityTypeConfiguration<RolePermissions>
    {
        public void Configure(EntityTypeBuilder<RolePermissions> builder)
        {
            builder.HasData(new RolePermissions[]
            {
                new RolePermissions
                {
                    RoleId = "2ab8d293-0e06-44a9-be5f-6d050e77f9be",
                    PermissionId = "98c40655-e7f1-4fe5-ac53-92b687e670a8",
                    Name="User"
                },
                new RolePermissions
                {
                    RoleId = "2ab8d293-0e06-44a9-be5f-6d050e77f9be",
                    PermissionId = "d8190480-ce9b-4570-80a9-2cbb6b1b178f",
                    Name="User",
                },
                new RolePermissions
                {
                    RoleId = "2ab8d293-0e06-44a9-be5f-6d050e77f9be",
                    PermissionId = "2635b3c0-1696-4bdf-b872-0fcf16dae2dd",
                    Name="User",
                },
                new RolePermissions
                {
                    RoleId = "2ab8d293-0e06-44a9-be5f-6d050e77f9be",
                    PermissionId = "57be7bb2-2e54-4e4b-9354-2d54f3608424",
                    Name="User",
                },
                new RolePermissions
                {
                    RoleId = "2ab8d293-0e06-44a9-be5f-6d050e77f9be",
                    PermissionId = "b0cd1b74-c49e-49a1-af99-7b18a9cec4fb",
                    Name="Role"
                },
                new RolePermissions
                {
                    RoleId = "2ab8d293-0e06-44a9-be5f-6d050e77f9be",
                    PermissionId = "c73afeb4-0dcd-4dea-a9d8-48b7aa75ca78",
                    Name="Role",
                },
                new RolePermissions
                {
                    RoleId = "2ab8d293-0e06-44a9-be5f-6d050e77f9be",
                    PermissionId = "4d37e9f9-aab2-41a3-a048-b37cd0ad4193",
                    Name="Role",
                },
                new RolePermissions
                {
                    RoleId = "2ab8d293-0e06-44a9-be5f-6d050e77f9be",
                    PermissionId = "8f676308-196e-46ea-a81d-3b7810a08b9e",
                    Name="Role",
                },
            });
        }
    }
}
