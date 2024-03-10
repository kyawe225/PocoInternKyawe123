using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Poco.UserModule.MVC.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "features",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "6dab512b-8734-4fdd-8c01-9ebf7a6fed87", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5884), false, "Update", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5885) },
                    { "81eba542-e560-4cb4-98c3-daded77676c4", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5871), false, "Create", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5872) },
                    { "e27ce0ba-bdca-450c-81ba-489f05866dd2", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5878), false, "View", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5879) },
                    { "fbcb82c7-48ee-4847-a337-c48aca9e66fb", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5890), false, "Delete", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5891) }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { "2ab8d293-0e06-44a9-be5f-6d050e77f9be", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5721), false, "Admin", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.InsertData(
                table: "adminUsers",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "Gender", "IsActive", "IsDeleted", "Name", "Password", "Phone", "RoleId", "UpdatedAt", "UserName" },
                values: new object[] { "7c5db4c0-a5bc-44b1-833b-6dd03d86865c", "Burma", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6236), "hello@gmail.com", true, true, false, "Hello", "12345", "123456789", "2ab8d293-0e06-44a9-be5f-6d050e77f9be", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6236), "KZH" });

            migrationBuilder.InsertData(
                table: "permissions",
                columns: new[] { "Id", "CreatedAt", "FeaturesId", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "2635b3c0-1696-4bdf-b872-0fcf16dae2dd", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5982), "6dab512b-8734-4fdd-8c01-9ebf7a6fed87", false, "User", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5982) },
                    { "4d37e9f9-aab2-41a3-a048-b37cd0ad4193", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6005), "6dab512b-8734-4fdd-8c01-9ebf7a6fed87", false, "Role", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6005) },
                    { "57be7bb2-2e54-4e4b-9354-2d54f3608424", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5988), "fbcb82c7-48ee-4847-a337-c48aca9e66fb", false, "User", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5988) },
                    { "8f676308-196e-46ea-a81d-3b7810a08b9e", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6011), "fbcb82c7-48ee-4847-a337-c48aca9e66fb", false, "Role", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6011) },
                    { "98c40655-e7f1-4fe5-ac53-92b687e670a8", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5968), "81eba542-e560-4cb4-98c3-daded77676c4", false, "User", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5968) },
                    { "b0cd1b74-c49e-49a1-af99-7b18a9cec4fb", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5993), "81eba542-e560-4cb4-98c3-daded77676c4", false, "Role", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5994) },
                    { "c73afeb4-0dcd-4dea-a9d8-48b7aa75ca78", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5999), "e27ce0ba-bdca-450c-81ba-489f05866dd2", false, "Role", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6000) },
                    { "d8190480-ce9b-4570-80a9-2cbb6b1b178f", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5976), "e27ce0ba-bdca-450c-81ba-489f05866dd2", false, "User", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(5976) }
                });

            migrationBuilder.InsertData(
                table: "rolePermissions",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "PermissionId", "RoleId", "UpdatedAt" },
                values: new object[,]
                {
                    { "0bd26cec-ab53-4569-8d69-07a23189eb71", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6120), false, "Role", "4d37e9f9-aab2-41a3-a048-b37cd0ad4193", "2ab8d293-0e06-44a9-be5f-6d050e77f9be", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6120) },
                    { "35d7b210-f407-4e03-b704-fb44636a104c", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6091), false, "User", "d8190480-ce9b-4570-80a9-2cbb6b1b178f", "2ab8d293-0e06-44a9-be5f-6d050e77f9be", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6091) },
                    { "4768ebc6-9df9-4183-bc10-a402ff886dfa", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6097), false, "User", "2635b3c0-1696-4bdf-b872-0fcf16dae2dd", "2ab8d293-0e06-44a9-be5f-6d050e77f9be", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6097) },
                    { "49dc0e47-bb12-4747-903e-f6c8fd52a09d", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6103), false, "User", "57be7bb2-2e54-4e4b-9354-2d54f3608424", "2ab8d293-0e06-44a9-be5f-6d050e77f9be", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6103) },
                    { "61148db0-0a1c-41c9-882b-858bdb322d8b", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6126), false, "Role", "8f676308-196e-46ea-a81d-3b7810a08b9e", "2ab8d293-0e06-44a9-be5f-6d050e77f9be", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6126) },
                    { "706969bb-bac5-430a-9789-25bdcd02e6da", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6114), false, "Role", "c73afeb4-0dcd-4dea-a9d8-48b7aa75ca78", "2ab8d293-0e06-44a9-be5f-6d050e77f9be", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6115) },
                    { "c5452c78-be76-4cd2-80af-5a568e90e63b", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6109), false, "Role", "b0cd1b74-c49e-49a1-af99-7b18a9cec4fb", "2ab8d293-0e06-44a9-be5f-6d050e77f9be", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6109) },
                    { "e980d1f1-433d-46d2-9034-93aefba5713b", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6081), false, "User", "98c40655-e7f1-4fe5-ac53-92b687e670a8", "2ab8d293-0e06-44a9-be5f-6d050e77f9be", new DateTime(2024, 3, 10, 17, 24, 12, 347, DateTimeKind.Utc).AddTicks(6082) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "adminUsers",
                keyColumn: "Id",
                keyValue: "7c5db4c0-a5bc-44b1-833b-6dd03d86865c");

            migrationBuilder.DeleteData(
                table: "rolePermissions",
                keyColumn: "Id",
                keyValue: "0bd26cec-ab53-4569-8d69-07a23189eb71");

            migrationBuilder.DeleteData(
                table: "rolePermissions",
                keyColumn: "Id",
                keyValue: "35d7b210-f407-4e03-b704-fb44636a104c");

            migrationBuilder.DeleteData(
                table: "rolePermissions",
                keyColumn: "Id",
                keyValue: "4768ebc6-9df9-4183-bc10-a402ff886dfa");

            migrationBuilder.DeleteData(
                table: "rolePermissions",
                keyColumn: "Id",
                keyValue: "49dc0e47-bb12-4747-903e-f6c8fd52a09d");

            migrationBuilder.DeleteData(
                table: "rolePermissions",
                keyColumn: "Id",
                keyValue: "61148db0-0a1c-41c9-882b-858bdb322d8b");

            migrationBuilder.DeleteData(
                table: "rolePermissions",
                keyColumn: "Id",
                keyValue: "706969bb-bac5-430a-9789-25bdcd02e6da");

            migrationBuilder.DeleteData(
                table: "rolePermissions",
                keyColumn: "Id",
                keyValue: "c5452c78-be76-4cd2-80af-5a568e90e63b");

            migrationBuilder.DeleteData(
                table: "rolePermissions",
                keyColumn: "Id",
                keyValue: "e980d1f1-433d-46d2-9034-93aefba5713b");

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: "2635b3c0-1696-4bdf-b872-0fcf16dae2dd");

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: "4d37e9f9-aab2-41a3-a048-b37cd0ad4193");

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: "57be7bb2-2e54-4e4b-9354-2d54f3608424");

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: "8f676308-196e-46ea-a81d-3b7810a08b9e");

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: "98c40655-e7f1-4fe5-ac53-92b687e670a8");

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: "b0cd1b74-c49e-49a1-af99-7b18a9cec4fb");

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: "c73afeb4-0dcd-4dea-a9d8-48b7aa75ca78");

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: "d8190480-ce9b-4570-80a9-2cbb6b1b178f");

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: "2ab8d293-0e06-44a9-be5f-6d050e77f9be");

            migrationBuilder.DeleteData(
                table: "features",
                keyColumn: "Id",
                keyValue: "6dab512b-8734-4fdd-8c01-9ebf7a6fed87");

            migrationBuilder.DeleteData(
                table: "features",
                keyColumn: "Id",
                keyValue: "81eba542-e560-4cb4-98c3-daded77676c4");

            migrationBuilder.DeleteData(
                table: "features",
                keyColumn: "Id",
                keyValue: "e27ce0ba-bdca-450c-81ba-489f05866dd2");

            migrationBuilder.DeleteData(
                table: "features",
                keyColumn: "Id",
                keyValue: "fbcb82c7-48ee-4847-a337-c48aca9e66fb");
        }
    }
}
