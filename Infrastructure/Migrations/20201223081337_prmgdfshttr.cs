using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class prmgdfshttr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationRole",
                columns: new[] { "Id", "ConcurrencyStamp", "IsRoot", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "0405cb6c-6b34-4407-9c48-836885d581d3", true, "Суперадмин", "СУПЕРАДМИН" },
                    { 2, "598b1376-5f40-40b5-a069-b3d89e8a1b68", true, "Администратор", "АДМИНИСТРАТОР" }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "AssignmentDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FairDate", "FirstName", "IsRoot", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Patronymic", "PhoneNumber", "PhoneNumberConfirmed", "Pin", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c94b51e5-52f3-4a06-a91b-f22a1588f9a4", null, false, null, "администратор", true, "Супер", false, null, "00000000000001", "00000000000001", "AQAAAAEAACcQAAAAEIfado8y0iGtqS7pg8XhrXMxd9N4uI9W2PRHK+HsSF/4AR4ULdP3jR9E05rr8dGqjA==", null, null, false, "00000000000001", "0382afaf-aeae-47ef-983d-c194ba94c64e", false, "00000000000001" });

            migrationBuilder.InsertData(
                table: "ApplicationUserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationRole",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ApplicationUserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ApplicationRole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
