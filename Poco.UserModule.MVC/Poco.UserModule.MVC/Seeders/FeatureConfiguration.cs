using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poco.UserModule.MVC.Entities;

namespace Poco.UserModule.MVC.Seeders
{
    public class FeatureConfiguration:IEntityTypeConfiguration<Features>
    {
        public void Configure(EntityTypeBuilder<Features> builder)
        {
            builder.HasData(new Features[]
            {
                new Features
                {
                    Id = "81eba542-e560-4cb4-98c3-daded77676c4",
                    Name="Create"
                },
                new Features
                {
                    Id = "e27ce0ba-bdca-450c-81ba-489f05866dd2",
                    Name="View"
                },
                new Features
                {
                    Id = "6dab512b-8734-4fdd-8c01-9ebf7a6fed87",
                    Name="Update"
                },
                new Features
                {
                    Id = "fbcb82c7-48ee-4847-a337-c48aca9e66fb",
                    Name="Delete"
                },
            });
        }
    }
}
