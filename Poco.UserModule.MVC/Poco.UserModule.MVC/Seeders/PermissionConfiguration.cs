using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poco.UserModule.MVC.Entities;

namespace Poco.UserModule.MVC.Seeders
{
    public class PermissionConfiguration:IEntityTypeConfiguration<Permissions>
    {
        public void Configure(EntityTypeBuilder<Permissions> builder)
        {
            builder.HasData(new Permissions[]
            {
                new Permissions
                {
                    Id = "98c40655-e7f1-4fe5-ac53-92b687e670a8",
                    Name="User",
                    FeaturesId = "81eba542-e560-4cb4-98c3-daded77676c4",
                },
                new Permissions
                {
                    FeaturesId = "e27ce0ba-bdca-450c-81ba-489f05866dd2",
                    Id = "d8190480-ce9b-4570-80a9-2cbb6b1b178f",
                    Name="User",
                },
                new Permissions
                {
                    FeaturesId = "6dab512b-8734-4fdd-8c01-9ebf7a6fed87",
                    Id = "2635b3c0-1696-4bdf-b872-0fcf16dae2dd",
                    Name="User",
                },
                new Permissions
                {
                    FeaturesId = "fbcb82c7-48ee-4847-a337-c48aca9e66fb",
                    Id = "57be7bb2-2e54-4e4b-9354-2d54f3608424",
                    Name="User",
                },
                new Permissions
                {
                    Id = "b0cd1b74-c49e-49a1-af99-7b18a9cec4fb",
                    Name="Role",
                    FeaturesId = "81eba542-e560-4cb4-98c3-daded77676c4",
                },
                new Permissions
                {
                    FeaturesId = "e27ce0ba-bdca-450c-81ba-489f05866dd2",
                    Id = "c73afeb4-0dcd-4dea-a9d8-48b7aa75ca78",
                    Name="Role",
                },
                new Permissions
                {
                    FeaturesId = "6dab512b-8734-4fdd-8c01-9ebf7a6fed87",
                    Id = "4d37e9f9-aab2-41a3-a048-b37cd0ad4193",
                    Name="Role",
                },
                new Permissions
                {
                    FeaturesId = "fbcb82c7-48ee-4847-a337-c48aca9e66fb",
                    Id = "8f676308-196e-46ea-a81d-3b7810a08b9e",
                    Name="Role",
                },
            });
        }
    }
}
