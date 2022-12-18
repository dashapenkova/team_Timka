using Microsoft.EntityFrameworkCore.Migrations;

namespace LNU.Migrations
{
    public partial class AddRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Identity",
                table: "AspNetUsers",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsSystemAdmin",
                schema: "Identity",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "Identity",
                table: "AspNetUsers",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f9322531-4f9b-4212-9bc0-6847a83f0e5d");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1308203a-ea77-4cf4-8443-26fcc91941e5");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                schema: "Identity",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email",
                schema: "Identity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Identity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsSystemAdmin",
                schema: "Identity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "Identity",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d62afc39-9044-4a87-a3d6-bd0de4ae9e4d");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d9644d1e-916d-4265-b7f1-e4a2fc2f86d1");
        }
    }
}
