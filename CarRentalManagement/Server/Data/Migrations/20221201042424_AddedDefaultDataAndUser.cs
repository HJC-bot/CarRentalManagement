using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdate",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdate",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdate",
                table: "Makes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdate",
                table: "Colours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "1e54ebc0-13a0-4a5a-a5fb-55e8f85b0269", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "62f7f62d-72bb-4897-a018-b616daa60afa", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "cbe90b2d-36bf-4d03-869d-1b3474aa25a1", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEKyQ34PQUi35oNJ4kjWLb40CXLOhnjX08OQs+uwp5s5KfwL/ljn2PzjzJpo20Eg/Pw==", null, false, "a01a5cf2-63e8-49ca-a847-a2625683414c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 12, 24, 23, 881, DateTimeKind.Local).AddTicks(7637), new DateTime(2022, 12, 1, 12, 24, 23, 883, DateTimeKind.Local).AddTicks(4931), "Black", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 12, 24, 23, 883, DateTimeKind.Local).AddTicks(5644), new DateTime(2022, 12, 1, 12, 24, 23, 883, DateTimeKind.Local).AddTicks(5647), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(4307), new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(4313), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(4316), new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(4317), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(1398), new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(1419), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(1422), new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(1423), "X5", "System" },
                    { 3, "System", new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(1425), new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(1426), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(1427), new DateTime(2022, 12, 1, 12, 24, 23, 885, DateTimeKind.Local).AddTicks(1428), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Makes");

            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Colours");

            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Bookings");
        }
    }
}
